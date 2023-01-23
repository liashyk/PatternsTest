namespace Singleton
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var goverment = Singleton.GetGoverment();

			Console.WriteLine(goverment.GetResultsofDoing());
			goverment.DoSomething();
			goverment = Singleton.GetGoverment();
			Console.WriteLine(goverment.GetResultsofDoing());
			Console.ReadKey();
		}
	}
}