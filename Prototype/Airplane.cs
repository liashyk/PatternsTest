using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	internal class Airplane
	{
		public int WingsAmount { get; set; }
		public string Color { get; set; }
		private string _technologyStuff;
		public string TechnologyStuff => _technologyStuff;
		public Airplane(int wingsAmount, string color)
		{
			WingsAmount = wingsAmount;
			Color = color;
			_technologyStuff = "nothing";
		}

		public void MakeTechlogyStuff()
		{
			_technologyStuff = "now it is must work";
		}

		public Airplane Clone()
		{
			return (Airplane)MemberwiseClone();
		}
	}
}
