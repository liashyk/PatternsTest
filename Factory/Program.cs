namespace Factory
{
	internal class Program
	{
		static void Run()
		{
			Console.WriteLine("Choose place:");
			Console.WriteLine("1.Sea");
			Console.WriteLine("2.Ground");

			int placeNumber = 0;

			string? placeNumberBuffer = Console.ReadLine();

			while (!int.TryParse(placeNumberBuffer, out placeNumber)
				|| placeNumber < 1 || placeNumber > 2)
			{
				Console.WriteLine("Something Wrong. Try again");
				placeNumberBuffer = Console.ReadLine();
			}

			IFactory factory;
			switch (placeNumber)
			{
				case 1:
					factory = new SeaFactory();
					break;
				case 2:
					factory = new GroundFactory();
					break;
				default:
					factory = new GroundFactory();
					break;
			}

			ITransport transport = factory.GetTransport();

			Console.WriteLine($"You get {transport.GetType()}");
			Console.WriteLine(transport.Deliver());
		}

		static void Main(string[] args)
		{
			Run();
		}
	}
}