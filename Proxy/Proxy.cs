using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	internal class Proxy:IDataService
	{
		private IDataService _dataService;
		public Proxy(IDataService service)
		{
			_dataService= service;
		}

		public string GetData()
		{
			Console.WriteLine("Do something before get data");
			string result = _dataService.GetData();
			Console.WriteLine("Do something after get data");
			return result;
		}
	}
}
