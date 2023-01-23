using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	internal class Good:IPriced
	{
		public Good(string name, double price) 
		{
			Name = name;
			Price = price;
		}
		public string Name { get; set; }
		public double Price { get; set; }

		public double GetPrice()
		{
			return Price;
		}
	}
}
