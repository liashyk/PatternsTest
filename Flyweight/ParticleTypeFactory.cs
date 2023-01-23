using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	internal class ParticleTypeFactory
	{
		static LinkedList<ParticleType> particleTypes;

		static ParticleTypeFactory()
		{
			particleTypes = new LinkedList<ParticleType>();
		}

		static ParticleType GetParticleType(Color color, int[][] sprite)
		{
			var returnParticle = particleTypes
				.Where(p => p.Color == color && p.Sprite == sprite)
				.FirstOrDefault();
			if (returnParticle == null)
			{
				returnParticle = new ParticleType(color, sprite);
				particleTypes.AddLast(returnParticle);
			}

			return returnParticle;
		}
	}
}
