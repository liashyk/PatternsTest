using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	internal class Circle
	{
		public double Radius { get; set; }
		public string Color { get; set; }
		public double Size => 2 * Math.PI * Radius;
	}
}
