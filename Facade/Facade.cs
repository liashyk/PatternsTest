using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	internal class Facade
	{
		private VeryComplicatedService service;

		public Facade()
		{
			service = new VeryComplicatedService();
		}
		public void MakeOperation()
		{
			service.MakeComplicateThing();
			service.MakeAnotherComplicateThing();
			service.MakeComplcateThingButEasierThatBefore();
			service.MakeTheMostComplicatedThing();
		}
	}
}
