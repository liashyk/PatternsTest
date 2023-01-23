namespace PatternsTest.Products
{

	class VictorianSofa : ISofa
	{
		public double Height => 400;

		public double Width => 200;

		public bool HasLegs => true;

		public string SitOn()
		{
			return "hmm, good victorian sofa";
		}
		public override string ToString()
		{
			return $"Height: {Height}; Width: {Width}; HasLegs: {HasLegs};";
		}
	}

	class ArDekoSofa : ISofa
	{
		public double Height => 60;

		public double Width => 200;

		public bool HasLegs => false;

		public string SitOn()
		{
			return "hmm, good ar-deko sofa";
		}
		public override string ToString()
		{
			return $"Height: {Height}; Width: {Width}; HasLegs: {HasLegs};";
		}
	}

	class ModernSofa : ISofa
	{
		public double Height => 80;

		public double Width => 150;

		public bool HasLegs => false;

		public string SitOn()
		{
			return "hmm, good modern sofa";
		}
		public override string ToString()
		{
			return $"Height: {Height}; Width: {Width}; HasLegs: {HasLegs};";
		}
	}
}
