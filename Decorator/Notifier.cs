using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	internal class Notifier : INotifier
	{
		public void SendMessage(string message)
		{
			Console.WriteLine("Base notifier write message");
		}
	}
}
