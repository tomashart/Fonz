using Fonz.Controllers.Grab;
using Fonz.Controllers.Reference;
using Fonz.Models;
using Storefront.Core.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fonz
{
	public partial class MainForm : Form
	{
		private bool _verified { get; set; }
		private List<Product> _products { get; set; }
		private List<Category> _categories { get; set; }
		private List<string> _comparisonData { get; set; }

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
				_comparisonData = ReferenceController.LoadFile();

				if (referenceComparisonDataHeaderCheckBox.Checked)
				{
					referenceComparisonDataGridView.DataSource = _comparisonData.Skip(1);
				}
				else
				{
					referenceComparisonDataGridView.DataSource = _comparisonData;
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

		private void Grab_Data_Commence(object sender, EventArgs e)
		{
			var selectors = new XmlProduct();

			if (grabDataNameLabel.Checked && !string.IsNullOrWhiteSpace(grabDataNameTextBox.Text))
				selectors.Add(new Selector(grabDataNameLabel.Text, grabDataNameTextBox.Text));

			if (grabDataFullDescriptionLabel.Checked && !string.IsNullOrWhiteSpace(grabDataFullDescriptionTextBox.Text))
				selectors.Add(new Selector(grabDataFullDescriptionLabel.Text, grabDataFullDescriptionTextBox.Text));

			if (grabDataPictureLabel.Checked && !string.IsNullOrWhiteSpace(grabDataPictureTextBox.Text))
				selectors.Add(new Selector(grabDataPictureLabel.Text, grabDataPictureTextBox.Text));

			if (grabDataAttributesLabel.Checked && !string.IsNullOrWhiteSpace(grabDataAttributesTextBox.Text))
				selectors.Add(new Selector(grabDataAttributesLabel.Text, grabDataAttributesTextBox.Text));

			if (grabDataCategoryLabel.Checked && !string.IsNullOrWhiteSpace(grabDataCategoryTextBox.Text))
				selectors.Add(new Selector(grabDataCategoryLabel.Text, grabDataCategoryTextBox.Text));

			if (grabDataDocumentsLabel.Checked && !string.IsNullOrWhiteSpace(grabDataDocumentsTextBox.Text))
				selectors.Add(new Selector(grabDataDocumentsLabel.Text, grabDataDocumentsTextBox.Text));

			//if (grabDataNameLabel.Checked && !string.IsNullOrWhiteSpace(grabDataNameTextBox.Text))
			//	selectors.Add(new Selector(grabDataNameLabel.Text, grabDataNameTextBox.Text));

			//if (grabDataFullDescriptionLabel.Checked && !string.IsNullOrWhiteSpace(grabDataFullDescriptionTextBox.Text))
			//	selectors.Add(new Selector(grabDataFullDescriptionLabel.Text, grabDataFullDescriptionTextBox.Text));

			//if (grabDataPictureLabel.Checked && !string.IsNullOrWhiteSpace(grabDataPictureTextBox.Text))
			//	selectors.Add(new Selector(grabDataPictureLabel.Text, grabDataPictureTextBox.Text));

			//if (grabDataAttributesLabel.Checked && !string.IsNullOrWhiteSpace(grabDataAttributesTextBox.Text))
			//	selectors.Add(new Selector(grabDataAttributesLabel.Text, grabDataAttributesTextBox.Text));

			//if (grabDataCategoryLabel.Checked && !string.IsNullOrWhiteSpace(grabDataCategoryTextBox.Text))
			//	selectors.Add(new Selector(grabDataCategoryLabel.Text, grabDataCategoryTextBox.Text));

			//if (grabDataDocumentsLabel.Checked && !string.IsNullOrWhiteSpace(grabDataDocumentsTextBox.Text))
			//	selectors.Add(new Selector(grabDataDocumentsLabel.Text, grabDataDocumentsTextBox.Text));

			//https://eshop.wuerth.de/0/<SKU>.sku/en/US/EUR/

			GrabController.Grab(grabSiteTextBox.Text, _comparisonData.ToArray(), selectors);
		}

		#endregion

		#region Serialize Tab

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