using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fonz.Controllers.Reference
{
	static class ReferenceController
	{
		public static bool VerifyConnection(string address, string database, string user, string password, string port)
		{
			MySql.Data.MySqlClient.MySqlConnection connection =
				new MySql.Data.MySqlClient.MySqlConnection(
					String.Format(
						"Server={0};Port={4};Database={1};Allow Zero Datetime=true;Convert Zero Datetime=True;Allow User Variables=True;Uid={2};Pwd={3};Charset=utf8;",
						address,
						database,
						user,
						password,
						port
					)
			);

			using (connection)
			{
				connection.Open();
			}

			return true;
		}

		public static List<Models.Reference> LoadFile()
		{
			var result = new List<Models.Reference>();

			Stream stream = null;

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "CSV files (*.csv)|*.csv";
			openFileDialog.InitialDirectory = @"C:\";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if ((stream = openFileDialog.OpenFile()) != null)
				{
					using (stream)
					{
						result = ReadCSV(openFileDialog.FileName, ',').ToList();
					}
				}
			}

			return result;
		}

		private static IEnumerable<Models.Reference> ReadCSV(string fileName, char seperator = ',')
		{
			var lines = File.ReadAllLines(Path.ChangeExtension(fileName, ".csv")).ToList();

			var result = new List<Models.Reference>();

			foreach (var line in lines)
			{
				var segments = line.Split(seperator);

				result.Add(
					new Models.Reference
						{
							Sku = segments[0].Replace("\"", ""),
							Gtin = segments[1].Replace(" ", "").Replace("\"", ""),
							ProductId = segments[2].Replace(" ", "").Replace("\"", "")
					}
				);
			}

			return result;
		}
	}
}