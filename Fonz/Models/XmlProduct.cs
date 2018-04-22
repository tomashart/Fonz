﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonz.Models
{
	class XmlProduct
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Picture { get; set; }
		public IEnumerable<string> Attributes { get; set; }
		public string Category { get; set; }
		public string Documents { get; set; }
	}
}
