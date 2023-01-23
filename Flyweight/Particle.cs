using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	internal class Paticle
	{
		public double[] Coordinates { get; set; }

		public ParticleType Type { get; set; }

		public Vector<double> Vector { get; set; }

		public double Speed { get; set; }

		public void Move() { }
		public void Draw() { }

	}
}
