using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonz.Models
{
	public class XmlProduct
	{
		public string Name { get; set; }
		public string Sku { get; set; }
		public string Gtin { get; set; }
		public string Description { get; set; }
		public string Picture { get; set; }
		public string[] Attributes { get; set; }
		public string[] Categories { get; set; }
		public string[] Documents { get; set; }
	}
}