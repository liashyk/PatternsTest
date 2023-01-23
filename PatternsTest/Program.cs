namespace PatternsTest
{
	internal class Program
	{
		static void Run()
		{
			Console.WriteLine("Choose product:");
			Console.WriteLine("1.Table");
			Console.WriteLine("2.Chair");
			Console.WriteLine("3.Sofa");
			int productNumber = 0;

			string? productNumberBuffer = Console.ReadLine();

			while (!int.TryParse(productNumberBuffer, out productNumber)
				|| productNumber < 1 || productNumber > 3)
			{
				Console.WriteLine("Something Wrong. Try again");
				productNumberBuffer = Console.ReadLine();
			}

			Console.WriteLine("Choose style:\n" +
				"1.ArDeko\n" +
				"2.Modern\n" +
				"3.Victorian");

			int styleNumber = 0;
			string? styleNumberBuffer = Console.ReadLine();

			while (!int.TryParse(productNumberBuffer, out productNumber)
				|| productNumber < 1 || productNumber > 3)
			{
				Console.WriteLine("Something Wrong. Try again");
				productNumberBuffer = Console.ReadLine();
			}

			IAbstarctFactory factory;
			switch (styleNumber)
			{
				case 1:
					factory = new ArDekoFactory();
					break;
				case 2:
					factory = new ModernFactory();
					break;
				case 3:
					factory = new VictorianFactory();
					break;
				default:
					factory = new VictorianFactory();
					break;
			}

			object furniture;
			switch (productNumber)
			{
				case 1:
					furniture = factory.GetTable();
					break;
				case 2:
					furniture = factory.GetArmchair();
					break;
				case 3:
					furniture = factory.GetSofa();
					break;
				default:
					furniture = factory.GetSofa();
					break;
			}
			Console.WriteLine($"You get {furniture.GetType()}");
			Console.WriteLine(furniture.ToString());
		}


		static void Main(string[] args)
		{
			Run();
		}
	}
}