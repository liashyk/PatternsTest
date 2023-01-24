using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	internal class SlackDecorator : BaseDecorator
	{
		public SlackDecorator(INotifier wrapee) : base(wrapee)
		{

		}

		public override void SendMessage(string message)
		{
			base.SendMessage(message);
			Console.WriteLine("Slack Decorator send message");
		}
	}
}
