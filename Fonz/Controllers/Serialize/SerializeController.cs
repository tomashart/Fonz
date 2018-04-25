using Fonz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Fonz.Controllers.Serialize
{
	public class SerializeController
	{
		public XmlDocument _document;
		public XmlElement _import;

		public void CreateDocument()
		{
			_document = new XmlDocument();
		}

		public void CreateImportElement()
		{
			_import = _document.CreateElement("import");
			_import.SetAttribute("products", "true"); //true value to check feed if any products are returned

			_document.AppendChild(_import);
		}

		public void CreateProductsElement(List<XmlProduct> feedProducts)
		{
			var products = _document.CreateElement("products");

			foreach (var product in feedProducts)
			{
				products.AppendChild(ProductNode(product));
			}

			_import.AppendChild(products);
		}

		public XmlElement ProductNode(XmlProduct feedProduct)
		{
			var product = _document.CreateElement("product");

			#region Product Attributes

			product.SetAttribute("sku", feedProduct.Sku);
			product.SetAttribute("gtin", feedProduct.Gtin);
			product.SetAttribute("fullName", feedProduct.Name);
			product.SetAttribute("type", "Stock");
			product.SetAttribute("draft", "false");

			#endregion

			// Descriptions
			if (!String.IsNullOrWhiteSpace(feedProduct.Description))
			{
				// Short Description
				product.AppendChild(ProductCDataSection("shortDescription", feedProduct.Description));

				// Full Description
				product.AppendChild(ProductCDataSection("fullDescription", feedProduct.Description));
			}

			// Categories
			if (feedProduct.Categories != null && feedProduct.Categories.Skip(1).Take(2).Count() > 0)
				product.AppendChild(ProductCategoriesNode(feedProduct.Categories.Skip(1).Take(2).ToArray()));

			// Pictures
			if (!String.IsNullOrEmpty(feedProduct.Picture))
				product.AppendChild(ProductPictureNode(feedProduct));

			// Attributes
			if (feedProduct.Attributes != null && feedProduct.Attributes.Count() > 0)
				product.AppendChild(ProductAttributesNode(feedProduct.Attributes));

			// Documents
			if (feedProduct.Documents != null && feedProduct.Documents.Where(d => d.EndsWith(".pdf")).Count() > 0)
				product.AppendChild(ProductDocumentsNode(feedProduct.Documents.Where(d => d.EndsWith(".pdf")).ToArray()));

			return product;
		}

		public XmlElement ProductCDataSection(String element, String data)
		{
			var node = _document.CreateElement(element);
			node.AppendChild(_document.CreateCDataSection(data));

			return node;
		}

		public XmlElement ProductCategoriesNode(List<String> data)
		{
			var node = _document.CreateElement("categories");

			foreach (var category in data)
			{
				var categoryNode = _document.CreateElement("category");
				categoryNode.SetAttribute("path", category);

				node.AppendChild(categoryNode);
			}

			return node;
		}

		public XmlElement ProductPictureNode(XmlProduct feedProduct)
		{
			var node = _document.CreateElement("pictures");

			var pictureNode = _document.CreateElement("picture");
			pictureNode.SetAttribute("name", feedProduct.Sku);
			pictureNode.SetAttribute("type", feedProduct.Picture.Substring(feedProduct.Picture.LastIndexOf('.') + 1));
			pictureNode.SetAttribute("format", "enum");
			pictureNode.SetAttribute("url", feedProduct.Picture);
			pictureNode.SetAttribute("useOriginal", "false");

			node.AppendChild(pictureNode);

			return node;
		}

		public XmlElement ProductCategoriesNode(string[] data)
		{
			var node = _document.CreateElement("categories");

			var categoryNode = _document.CreateElement("category");

			var categoryPath = String.Empty;

			foreach (var category in data)
			{
				categoryPath += String.Concat("/" + category.Replace("/", "-"));
			}

			categoryNode.SetAttribute("path", categoryPath);

			node.AppendChild(categoryNode);

			return node;
		}

		public XmlElement ProductAttributesNode(string[] data)
		{
			var node = _document.CreateElement("attributes");

			var setNode = _document.CreateElement("set");
			setNode.SetAttribute("name", "Technical Information");

			for (int i = 0; i <= data.Count() - 1 && i % 2 == 0; i+= 2)
			{
				var attributeNode = _document.CreateElement("attribute");
				attributeNode.SetAttribute("name", data[i]);
				attributeNode.SetAttribute("value", data[i+1]);

				setNode.AppendChild(attributeNode);
			}

			node.AppendChild(setNode);

			return node;
		}

		public XmlElement ProductDocumentsNode(string[] data)
		{
			var node = _document.CreateElement("documents");

			foreach (var document in data)
			{
				var categoryNode = _document.CreateElement("document");
				categoryNode.SetAttribute("source", document);

				node.AppendChild(categoryNode);
			}

			return node;
		}
	}
}