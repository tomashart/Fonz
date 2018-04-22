using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storefront.Core.Domain.Catalog;
using Storefront.Data;

namespace Fonz.Controllers.Trawl
{
	class TrawlController : ITrawlController
	{
		public bool _verified { get; set; }

		private IDataRepository<Product> _productRepo { get; }
		private IDataRepository<Category> _categoryRepo { get; }

		public TrawlController
		(
			IDataRepository<Product> productRepo
			//,IDataRepository<Category> categoryRepo
		)
		{
			this._productRepo = productRepo;
			//this._categoryRepo = categoryRepo;
		}
	}
}
