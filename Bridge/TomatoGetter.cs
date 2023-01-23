using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	internal class TomatoGetter : ISomethingGetter
	{
		public string GetSomething()
		{
			return "i give you tomato";
		}
	}
}
