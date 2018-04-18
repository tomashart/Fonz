using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storefront.Data;
using Storefront.Core.Domain.Catalog;

namespace Fonz.Controllers
{
	interface ICatalogueController
	{
		IDataRepository<Product> _productRepo { get; set; }
		IDataRepository<Category> _categoryRepo { get; set; }
	}
}
