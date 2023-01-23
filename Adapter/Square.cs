using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	internal class Square
	{
		public double Width { get; set; }
		public string Color { get; set; }
		public double Size => Width * Width;
	}
}
