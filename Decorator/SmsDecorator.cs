using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	internal class SmsDecorator : BaseDecorator
	{
		public SmsDecorator(INotifier wrapee) : base(wrapee)
		{
		}

		public override void SendMessage(string message)
		{
			base.SendMessage(message);
			Console.WriteLine("Sms Decorator send message");
		}
	}
}
