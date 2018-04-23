using AngleSharp;
using Fonz.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fonz.Controllers.Grab
{
	static class GrabController
	{
		public static async void Grab(string baseAddress, string[] dataSet, XmlProduct selectors)
		{
			var result = new List<XmlProduct>();

			var config = Configuration.Default.WithDefaultLoader();

			foreach (var single in dataSet)
			{
				var product = new XmlProduct();

				var document = await BrowsingContext.New(config).OpenAsync(baseAddress.Replace("<SKU>", single).Replace("<ProductId>", single));

				product.Name = document.QuerySelector(selectors.Name).TextContent;
				product.Description = document.QuerySelector(selectors.Description).TextContent;
				product.Category = document.QuerySelector(selectors.Category).TextContent;
				product.Attributes = new List<string>() { document.QuerySelector(selectors.Attributes.First()).TextContent };


				//foreach (var cellSelector in selectors)
				//{
				//	var cells = document.QuerySelectorAll(cellSelector);
				//}
			}
		}
	}
}