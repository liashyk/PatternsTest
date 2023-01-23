using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	internal class Adapter
	{
		public Circle ToCircle(Square square)
		{
			return new Circle { Color = square.Color,Radius=square.Width };
		}

		public Square ToSquare(Circle circle)
		{
			return new Square { Color = circle.Color, Width = circle.Radius };
		}
	}
}
