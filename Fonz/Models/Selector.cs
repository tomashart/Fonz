using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonz.Models
{
	public class Selector
	{
		public string Name { get; set; }
		public string Value { get; set; }

		public Selector(string name, string value)
		{
			Name = name;
			Value = value;
		}
	}
}
