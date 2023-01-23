using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	internal class ParticleType
	{
		public Color Color { get; }
		public int[][] Sprite { get; }
		public ParticleType(Color color, int[][] sprite)
		{
			Color = color;
			Sprite = sprite;
		}

		public void Move() { }
		public void Draw() { }
	}
}
