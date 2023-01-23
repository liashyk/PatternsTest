using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	internal class Box:IPriced
	{
		private LinkedList<IPriced> _children;

		public Box()
		{
			_children = new LinkedList<IPriced>();
		}

		public void Add(IPriced child)
		{
			_children.AddLast(child);
		}

		public void Remove(IPriced child) 
		{
			_children.Remove(child);
		}
		public IEnumerable<IPriced> GetChildern()
		{
			return Enumerable.ToArray(_children);
		}

		public double GetPrice()
		{
			double price = 0;
			foreach(var priced in _children)
			{
				price += priced.GetPrice();
			}
			return price;
		}
	}
}
