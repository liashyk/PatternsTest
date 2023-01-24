namespace Proxy
{
	internal class Program
	{
		static void Run()
		{
			IDataService dataService = new DataBaseService();
			IDataService dataServiceProxy = new Proxy(dataService);
			ShowData(dataServiceProxy);
		}

		static void ShowData(IDataService dataService)
		{
			string data = dataService.GetData();
			Console.WriteLine(data);
		}


		static void Main(string[] args)
		{
			Run();
		}
	}
}