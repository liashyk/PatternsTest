using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	internal class Builder : IBuilder
	{
		public Builder()
		{
			_house = new House();
		}

		private House _house;

		public void Reset()
		{
			_house = new House();
		}

		public void SetDoors(int amount)
		{
			_house.DoorsAmount = amount;
		}

		public void SetGarage(bool hasGarage)
		{
			_house.HasGarage = hasGarage;
		}

		public void SetGarden(bool hasGarden)
		{
			_house.HasGarden = hasGarden;
		}

		public void SetRooms(int amount)
		{
			_house.RoomsAmount = amount;
		}

		public void SetWindows(int amount)
		{
			_house.WindowsAmount = amount;
		}

		public House GetResult()
		{
			return _house;
		}
	}
}
