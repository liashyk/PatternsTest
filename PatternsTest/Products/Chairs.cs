namespace PatternsTest.Products
{
	class VictorianArmChair : IArmchair
	{
		private double height = 1000;
		public double Height => height;

		public bool IsSoft()
		{
			return true;
		}

		public string SitOn()
		{
			return "hmm, good victorian chair";
		}

		public override string ToString()
		{
			return $"Height: {Height}; IsSoft: {IsSoft};";
		}
	}

	class ArDekoArmChair : IArmchair
	{
		private double height = 600;
		public double Height => height;

		public bool IsSoft()
		{
			return true;
		}

		public string SitOn()
		{
			return "hmm, good ar-deko chair";
		}
		public override string ToString()
		{
			return $"Height: {Height}; IsSoft: {IsSoft};";
		}
	}

	class ModernArmChair : IArmchair
	{
		private double height = 800;
		public double Height => height;

		public bool IsSoft()
		{
			return false;
		}

		public string SitOn()
		{
			return "hmm, good modern chair";
		}
		public override string ToString()
		{
			return $"Height: {Height}; IsSoft: {IsSoft};";
		}
	}

}
