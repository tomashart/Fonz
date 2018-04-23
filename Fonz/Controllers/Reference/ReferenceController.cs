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

		public static List<string> LoadFile()
		{
			var result = new List<string>();

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

		private static IEnumerable<string> ReadCSV(string fileName, char seperator = ',')
		{
			var lines = File.ReadAllLines(Path.ChangeExtension(fileName, ".csv")).ToList();

			//scrubba-dub-dub
			lines.ForEach(
				l => l.Replace(" ", "").Replace("\"", "")
			);

			return lines;
		}
	}
}