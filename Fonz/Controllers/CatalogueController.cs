using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storefront.Data;
using Storefront.Core.Domain.Catalog;

namespace Fonz.Controllers
{
	class CatalogueController : ICatalogueController
	{
		public IDataRepository<Product> _productRepo { get; set; }
		public IDataRepository<Category> _categoryRepo { get; set; }

		public CatalogueController
		(
			IDataRepository<Product> productRepo,
			IDataRepository<Category> categoryRepo
		)
		{
			_productRepo = productRepo;
			_categoryRepo = categoryRepo;
		}
	}
}
