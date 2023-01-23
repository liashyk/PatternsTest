using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal class Director
	{
		private IBuilder _builder;
		public Director(IBuilder builder) 
		{
			_builder = builder;
		}

		public void MakeSimpleHouse()
		{
			_builder.Reset();
			_builder.SetWindows(2);
			_builder.SetRooms(1);
			_builder.SetDoors(1);
		}

		public void MakeRichHouse()
		{
			_builder.Reset();
			_builder.SetRooms(8);
			_builder.SetDoors(3);
			_builder.SetWindows(15);
			_builder.SetGarage(true);
			_builder.SetGarden(true);
		}

	}
}
