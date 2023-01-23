using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	internal class Abstraction
	{
		public int SomeProperty { get; set; }

		private ISomethingGetter _somethingGetter;

		public Abstraction(ISomethingGetter somethingGetter)
		{
			_somethingGetter=somethingGetter;
		}

		public void DoSomething()
		{
			Console.WriteLine( _somethingGetter.GetSomething());
		}
	}
}
