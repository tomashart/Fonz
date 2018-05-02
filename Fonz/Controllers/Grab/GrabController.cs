using AngleSharp;
using Fonz.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Fonz.Controllers.Grab
{
	class GrabController
	{
		public List<XmlProduct> _grabbedData { get; set; }

		public async Task GrabAsync(string baseAddress, List<Models.Reference> dataSet, XmlProduct selectors, string identifier = "<SKU>")
		{
			_grabbedData = new List<XmlProduct>();

			var config = Configuration.Default.WithDefaultLoader();

			foreach (var reference in dataSet)
			{
				var product = new XmlProduct();

				var single = "";

				if (identifier == "<SKU>")
				{
					single = reference.Sku.Replace(" ", "").Remove(0, 1);
				}
				else
				{
					single = reference.ProductId;
				}

				var document = await BrowsingContext.New(config).OpenAsync(baseAddress.Replace(identifier, single));

				if (document.QuerySelector("body.product_ProductNotAvailable") != null)
					continue;

				if (document.QuerySelector("body.product_OfflineProduct") != null)
					continue;

				product.Name = document.QuerySelector(selectors.Name) != null ? document.QuerySelector(selectors.Name).TextContent.Replace("\n", "") : null;

				if (product.Name == null)
					continue;

				product.Sku = reference.Sku;
				product.Gtin = reference.Gtin;
				product.Description = document.QuerySelector(selectors.Description) != null ? document.QuerySelector(selectors.Description).TextContent.Replace("\n", "") : null;
				product.Picture = document.QuerySelector(selectors.Picture) != null ? document.QuerySelector(selectors.Picture).GetAttribute("src").Replace("\n", "") : null;
				product.Categories = document.QuerySelectorAll(selectors.Categories.First()).ToList().Select(d => d.TextContent.Replace("\n", "")).ToArray();
				product.Attributes = document.QuerySelectorAll(selectors.Attributes.First()) != null ? document.QuerySelectorAll(selectors.Attributes.First()).ToList().Select(a => a.TextContent.Replace("\n", "")).ToArray() : null;
				product.Documents = document.QuerySelectorAll(selectors.Documents.First()) != null ? document.QuerySelectorAll(selectors.Documents.First()).ToList().Select(d => d.GetAttribute("href")).ToArray() : null;

				_grabbedData.Add(product);
			}
		}
	}
}