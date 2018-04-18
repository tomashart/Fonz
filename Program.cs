using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storefront.Data;
using Storefront.Core.Domain.Catalog;
using Autofac;

namespace Fonz
{
	static class Program
	{
		private static IContainer Container { get; set; }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			DependencyConfig dp = new DependencyConfig();

			var builder = new ContainerBuilder();
			//builder.RegisterType<IDataRepository<Product>>();
			//Container = builder.Build();

			dp.RegisterDependencies(builder);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
