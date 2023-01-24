using System.ComponentModel;

namespace Decorator
{
	internal class Program
	{
		static void Run()
		{
			//make base notifier
			INotifier notifier = new Notifier();

			//add sms
			notifier = new SmsDecorator(notifier);

			//add facebook
			notifier = new FacebookDecorator(notifier);

			//add facebook
			notifier = new SlackDecorator(notifier);

			notifier.SendMessage("message");
		}

		static void Main(string[] args)
		{
			Run();
		}
	}
}