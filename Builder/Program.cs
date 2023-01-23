namespace Builder
{
	internal class Program
	{
		static void Run()
		{
			Console.WriteLine("Choose house:");
			Console.WriteLine("1.Rich house");
			Console.WriteLine("2.Simple house");
			int houseNumber = 0;

			string? productNumberBuffer = Console.ReadLine();

			while (!int.TryParse(productNumberBuffer, out houseNumber)
				|| houseNumber < 1 || houseNumber > 3)
			{
				Console.WriteLine("Something Wrong. Try again");
				productNumberBuffer = Console.ReadLine();
			}

			Builder builder= new Builder();
			Director director = new Director(builder);

			switch (houseNumber)
			{
				case 1:
					director.MakeSimpleHouse();
					break;
				case 2:
					director.MakeRichHouse();
					break;
				default:
					director.MakeSimpleHouse();
					break;
			}

			House house = builder.GetResult();
			Console.WriteLine(house.ToString());

		}
		static void Main(string[] args)
		{
			Run();
		}
	}
}