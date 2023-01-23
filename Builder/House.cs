namespace Builder
{
	internal class House
	{
		public House(int windows = 1, int doors = 1, int rooms = 1, bool garage = false, bool garden = false)
		{
			WindowsAmount = windows;
			DoorsAmount = doors;
			RoomsAmount = rooms;
			HasGarage = garage;
			HasGarden = garden;
		}
		public int WindowsAmount { get; set; }
		public int DoorsAmount { get; set; }
		public int RoomsAmount { get; set; }
		public bool HasGarage { get; set; }
		public bool HasGarden { get; set; }

		public override string ToString()
		{
			return $"Windows: {WindowsAmount}; DoorsAmount: {DoorsAmount}; RoomsAmount: {RoomsAmount}; HasGarage: {HasGarage}; HasGarden: {HasGarden};";
		}
	}
}
