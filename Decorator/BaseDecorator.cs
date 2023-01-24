using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	internal class BaseDecorator:INotifier
	{
		private INotifier _wrapee;

		public BaseDecorator(INotifier wrapee)
		{
			_wrapee = wrapee;
		}

		public virtual void SendMessage(string message)
		{
			_wrapee.SendMessage(message);
		}
	}
}
