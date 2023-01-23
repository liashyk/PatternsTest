namespace PatternsTest.Products
{
	class VictorianTable : ITable
	{
		public double Height => 70;

		public double Width => 100;

		public bool HasLegs => true;

		public bool IsOval => true;

		public double Length => 100;
		public override string ToString()
		{
			return $"Height: {Height}; Width: {Width}; HasLegs: {HasLegs}; IsOval: {IsOval}; Length: {Length}";
		}
	}

	class ModernTable : ITable
	{
		public double Height => 60;

		public double Width => 100;

		public bool HasLegs => false;

		public bool IsOval => false;

		public double Length => 200;

		public override string ToString()
		{
			return $"Height: {Height}; Width: {Width}; HasLegs: {HasLegs}; IsOval: {IsOval}; Length: {Length}";
		}
	}

	class ArDekoTable : ITable
	{
		public double Height => 80;

		public double Width => 90;

		public bool HasLegs => true;

		public bool IsOval => false;

		public double Length => 90;

		public override string ToString()
		{
			return $"Height: {Height}; Width: {Width}; HasLegs: {HasLegs}; IsOval: {IsOval}; Length: {Length}";
		}
	}
}
