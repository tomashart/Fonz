using Fonz.Controllers.Grab;
using Fonz.Controllers.Reference;
using Fonz.Controllers.Serialize;
using Fonz.Models;
using Storefront.Core.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Fonz
{
	public partial class MainForm : Form
	{
		private bool _verified { get; set; }
		private List<XmlProduct> _grabbedData { get; set; }
		private List<Category> _categories { get; set; }
		private List<Models.Reference> _comparisonData { get; set; }

		public MainForm()
		{
			InitializeComponent();
		}

		#region UI Events

		#region Reference Tab

		private void Reference_ConnectionString_Verify(object sender, EventArgs e)
		{
			referenceConnectionStringGroupBox.Enabled = false;
			referenceConnectionStringUserTextBox.Enabled = false;
			referenceConnectionStringPasswordTextBox.Enabled = false;
			referenceConnectionStringDatabaseTextBox.Enabled = false;
			referenceConnectionStringAddressTextBox.Enabled = false;
			referenceConnectionStringPortTextBox.Enabled = false;

			try
			{
				WriteLine(consoleTextBox, "Verifying connection string settings");

				string user = referenceConnectionStringUserTextBox.Text.ToString() ?? "";
				string password = referenceConnectionStringPasswordTextBox.Text.ToString() ?? "";
				string database = referenceConnectionStringDatabaseTextBox.Text.ToString() ?? "";
				string address = referenceConnectionStringAddressTextBox.Text.ToString() ?? "";
				string port = referenceConnectionStringPortTextBox.Text.ToString() ?? "";

				if
				(
					string.IsNullOrWhiteSpace(user) ||
					string.IsNullOrWhiteSpace(password) ||
					string.IsNullOrWhiteSpace(database) ||
					string.IsNullOrWhiteSpace(address) ||
					string.IsNullOrWhiteSpace(port)
				)
				{
					throw new Exception("One or more values provided in the Connection String section are invalid");
				}
				else
				{
					_verified = ReferenceController.VerifyConnection(address, database, user, password, port);

					WriteLine(consoleTextBox, "Connection verified");
				}
			}
			catch (Exception ex)
			{
				WriteLine(consoleTextBox, "Exception encountered: " + ex.Message);
			}

			referenceConnectionStringGroupBox.Enabled = true;
			referenceConnectionStringUserTextBox.Enabled = true;
			referenceConnectionStringPasswordTextBox.Enabled = true;
			referenceConnectionStringDatabaseTextBox.Enabled = true;
			referenceConnectionStringAddressTextBox.Enabled = true;
			referenceConnectionStringPortTextBox.Enabled = true;
		}

		private void Reference_ComparisonData_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = new DataTable();

				referenceComparisonDataGridView.DataSource = null;

				List<Models.Reference> fileData = ReferenceController.LoadFile();

				//dt.Columns.Add(referenceComparisonDataProductIdRadio.Checked ? "ProductId" : "SKU");

				dt.Columns.Add("Sku");
				dt.Columns.Add("Gtin");
				dt.Columns.Add("ProductId");

				if (referenceComparisonDataHeaderCheckBox.Checked)
				{
					_comparisonData = fileData.Skip(1).ToList();

					foreach (var item in _comparisonData)
					{
						//dt.Rows.Add(item);
						dt.Rows.Add(new { item.Sku }, new { item.Gtin }, new { item.ProductId } );
					}

					referenceComparisonDataGridView.DataSource = dt;
				}
				else
				{
					_comparisonData = fileData;

					foreach (var item in _comparisonData)
					{
						//dt.Rows.Add(item);
						dt.Rows.Add(new { item.Sku }, new { item.Gtin }, new { item.ProductId });
					}

					referenceComparisonDataGridView.DataSource = dt;
				}

				WriteLine(consoleTextBox, "Row(s) imported successfully: " + _comparisonData.Count);
			}
			catch (Exception ex)
			{
				WriteLine(consoleTextBox, "Exception encountered: " + ex.Message);
			}
		}

		private void Reference_ComparisonData_Generate(object sender, EventArgs e)
		{
			//	try
			//	{
			//		if (_verified)
			//		{
			//			if (trawlComparisonDataProductsCheckBox.Checked)
			//			{
			//				//Get products
			//				//_products = _productRepo.Table.Where();
			//			}

			//			if (trawlComparisonDataCategoriesCheckBox.Checked)
			//			{
			//				//Get categories
			//			}
			//		}
			//	}
			//	catch (Exception)
			//	{

			//		throw;
			//	}
		}

		#endregion

		#region Grab Tab

		private async void Grab_Data_Commence(object sender, EventArgs e)
		{
			var selectors = new XmlProduct();

			if (grabDataNameLabel.Checked && !string.IsNullOrWhiteSpace(grabDataNameTextBox.Text))
				selectors.Name = grabDataNameTextBox.Text;

			if (grabDataFullDescriptionLabel.Checked && !string.IsNullOrWhiteSpace(grabDataFullDescriptionTextBox.Text))
				selectors.Description = grabDataFullDescriptionTextBox.Text;

			if (grabDataPictureLabel.Checked && !string.IsNullOrWhiteSpace(grabDataPictureTextBox.Text))
				selectors.Picture = grabDataPictureTextBox.Text;

			if (grabDataAttributesLabel.Checked && !string.IsNullOrWhiteSpace(grabDataAttributesTextBox.Text))
				selectors.Attributes = new string[] { grabDataAttributesTextBox.Text };

			if (grabDataCategoryLabel.Checked && !string.IsNullOrWhiteSpace(grabDataCategoryTextBox.Text))
				selectors.Categories = new string[] { grabDataCategoryTextBox.Text };

			if (grabDataDocumentsLabel.Checked && !string.IsNullOrWhiteSpace(grabDataDocumentsTextBox.Text))
				selectors.Documents = new string[] { grabDataDocumentsTextBox.Text };

			WriteLine(consoleTextBox, "Grabbing data");

			GrabController gc = new GrabController();

			await gc.GrabAsync(grabSiteTextBox.Text, _comparisonData.ToList(), selectors);

			_grabbedData = gc._grabbedData;

			WriteLine(consoleTextBox, "Product(s) imported successfully: " + _grabbedData.Count);
		}

		#endregion

		#region Serialize Tab

		private void Serialize_XML_Save(object sender, EventArgs e)
		{
			SerializeController sc = new SerializeController();

			WriteLine(consoleTextBox, "Serializing data");

			sc.CreateDocument();

			sc.CreateImportElement();

			sc.CreateProductsElement(_grabbedData);

			sc._document.Save("C:\\Projects\\Storefront 7\\Fonz\\xmlgenerate.xml");

			WriteLine(consoleTextBox, "Data serialized successfully");
		}

		#endregion

		#region Global

		private void Console_Clear(object sender, EventArgs e)
		{
			consoleTextBox.Clear();
		}

		#endregion

		#endregion

		#region Utility Methods

		private static void WriteLine(RichTextBox control, string text, bool newline = true)
		{
			control.AppendText(String.Concat(text, newline ? "\n" : ""));
		}

		#endregion
	}
}