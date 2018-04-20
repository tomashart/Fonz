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
			builder.RegisterGeneric(typeof(DataRepository<>)).As(typeof(IDataRepository<>)).InstancePerRequest();
		}
	}
}
