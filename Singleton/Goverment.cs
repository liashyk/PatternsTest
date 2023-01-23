using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	internal class Goverment
	{

		public string Country { get; set; }

		private int _somethingCounter;

		public Goverment(string country="Ukraine") 
		{
			_somethingCounter= 0;
			Country = country;
		}

		public void DoSomething()
		{
			_somethingCounter++;
		}

		public string GetResultsofDoing()
		{
			return $"We make something {_somethingCounter} times!";
		}

	}
}
