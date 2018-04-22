using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storefront.Data;
using Storefront.Core.Domain.Catalog;
using Storefront.Services.Catalog;
using Autofac;
using Fonz.Controllers.Trawl;

namespace Fonz
{
	public partial class MainForm : Form
	{
		private bool _verified { get; set; }
		private List<Product> _products { get; set; }
		private List<Category> _categories { get; set; }

		public MainForm()
		{
			DependencyConfig dp = new DependencyConfig();
			ContainerBuilder builder = new ContainerBuilder();
			dp.RegisterDependencies(builder);

			InitializeComponent();
		}

		private void Verify_Click(object sender, EventArgs e)
		{
			progressBar.Value = 0;

			trawlConnectionStringGroupBox.Enabled = false;
			trawlConnectionStringUserTextBox.Enabled = false;
			trawlConnectionStringPasswordTextBox.Enabled = false;
			trawlConnectionStringDatabaseTextBox.Enabled = false;
			trawlConnectionStringAddressTextBox.Enabled = false;
			trawlConnectionStringPortTextBox.Enabled = false;

			try
			{
				trawlConsoleTextBox.AppendText("Verifying connection string settings" + "\n");

				string user = trawlConnectionStringUserTextBox.Text.ToString() ?? "";
				string password = trawlConnectionStringPasswordTextBox.Text.ToString() ?? "";
				string database = trawlConnectionStringDatabaseTextBox.Text.ToString() ?? "";
				string address = trawlConnectionStringAddressTextBox.Text.ToString() ?? "";
				string port = trawlConnectionStringPortTextBox.Text.ToString() ?? "";

				if (progressBar.Value < 100) progressBar.Value += 10;

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
					MySql.Data.MySqlClient.MySqlConnection connection =
						new MySql.Data.MySqlClient.MySqlConnection(
							String.Format(
								"Server={0};Port=3306;Database={1};Allow Zero Datetime=true;Convert Zero Datetime=True;Allow User Variables=True;Uid={2};Pwd={3};Charset=utf8;",
								address,
								database,
								user,
								password
							)
						);

					using (connection)
					{
						connection.Open();
					}

					_verified = true;

					trawlConsoleTextBox.AppendText("Connection verified" + "\n");

					if (progressBar.Value < 100) progressBar.Value += 10;
				}

				if (progressBar.Value < 100) progressBar.Value += 10;
			}
			catch (Exception ex)
			{
				progressBar.Value = 0;

				trawlConsoleTextBox.AppendText("Exception encountered: " + ex.Message + "\n");
			}

			trawlConnectionStringGroupBox.Enabled = true;
			trawlConnectionStringUserTextBox.Enabled = true;
			trawlConnectionStringPasswordTextBox.Enabled = true;
			trawlConnectionStringDatabaseTextBox.Enabled = true;
			trawlConnectionStringAddressTextBox.Enabled = true;
			trawlConnectionStringPortTextBox.Enabled = true;

			progressBar.Value = 0;
		}

		private void Trawl_Clear_Click(object sender, EventArgs e)
		{
			trawlConsoleTextBox.Clear();
		}

		#region Subsets

		//private void Trawl_Products_Changed(object sender, EventArgs e)
		//{
		//	if (trawlComparisonDataProductsCheckBox.Checked)
		//	{
		//		trawlComparisonDataProductsSkuCheckBox.Enabled = true;
		//		trawlComparisonDataProductsNameCheckBox.Enabled = true;
		//		trawlComparisonDataProductsGtinCheckBox.Enabled = true;
		//	}
		//	else
		//	{
		//		trawlComparisonDataProductsSkuCheckBox.Enabled = false;
		//		trawlComparisonDataProductsSkuCheckBox.Checked = false;
		//		trawlComparisonDataProductsNameCheckBox.Enabled = false;
		//		trawlComparisonDataProductsNameCheckBox.Checked = false;
		//		trawlComparisonDataProductsGtinCheckBox.Enabled = false;
		//		trawlComparisonDataProductsGtinCheckBox.Checked = false;
		//	}
		//}

		//private void Trawl_Categories_Changed(object sender, EventArgs e)
		//{
		//	if (trawlComparisonDataCategoriesCheckBox.Checked)
		//	{
		//		trawlComparisonDataCategoriesDisplayOrderCheckBox.Enabled = true;
		//		trawlComparisonDataCategoriesNameCheckBox.Enabled = true;
		//		trawlComparisonDataCategoriesPathCheckBox.Enabled = true;
		//	}
		//	else
		//	{
		//		trawlComparisonDataCategoriesDisplayOrderCheckBox.Enabled = false;
		//		trawlComparisonDataCategoriesDisplayOrderCheckBox.Checked = false;
		//		trawlComparisonDataCategoriesNameCheckBox.Enabled = false;
		//		trawlComparisonDataCategoriesNameCheckBox.Checked = false;
		//		trawlComparisonDataCategoriesPathCheckBox.Enabled = false;
		//		trawlComparisonDataCategoriesPathCheckBox.Checked = false;
		//	}
		//}

		#endregion

		private void Trawl_Generate_Click(object sender, EventArgs e)
		{
			try
			{
				if (_verified)
				{
					if (trawlComparisonDataProductsCheckBox.Checked)
					{
						//Get products
						//_products = _productRepo.Table.Where();
					}

					if (trawlComparisonDataCategoriesCheckBox.Checked)
					{
						//Get categories
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void ToggleStatus()
		{
			//if (control.HasChildren)
			//{
			//	foreach (var child in control)
			//	{

			//	}
			//}
		}
	}
}
