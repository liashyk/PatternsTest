using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal interface IBuilder
	{
		void Reset();
		void SetWindows(int amount);
		void SetDoors(int amount);
		void SetRooms(int amount);
		void SetGarage(bool hasGarage);
		void SetGarden(bool hasGarden);
	}
}
