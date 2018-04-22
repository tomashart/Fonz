using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;

namespace Fonz.Controllers.Grab
{
	static class GrabController
	{
		//static GrabController() { }

		public static async void Grab(string[] addresses, string[] selectors)
		{
			var config = Configuration.Default.WithDefaultLoader();

			foreach (var address in addresses)
			{
				var document = await BrowsingContext.New(config).OpenAsync(address);

				foreach (var cellSelector in selectors)
				{
					var cells = document.QuerySelectorAll(cellSelector);
				}
			}
		}
	}
}