using Autofac;
using Storefront.Core.Infrastructure;
using Storefront.Data;
using Storefront.Core.Domain.Catalog;

namespace Fonz
{
	public class DependencyConfig : IDependencyRegistrar
	{
		public void RegisterDependencies(ContainerBuilder builder)
		{
			//builder.RegisterType<MainForm>().As<IDataRepository<Product>>().InstancePerRequest();
			//builder.RegisterType<MainForm>().As<IDataRepository<Category>>().InstancePerRequest();
			builder.RegisterGeneric(typeof(DataRepository<>)).As(typeof(IDataRepository<>)).InstancePerRequest();
		}
	}
}
