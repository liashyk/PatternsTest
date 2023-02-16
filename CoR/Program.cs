namespace CoR
{
	internal class Program
	{
		interface IHandler
		{
			void Handle(string message);
		}

		abstract class Handler : IHandler
		{
			private IHandler? next;

			public void AddNext(IHandler handler)
			{
				next = handler;
			}

			public virtual void Handle(string message)
			{
				if (next != null && message!=null)
				{
					next.Handle(message);
				}
			}
		}

		class AuthorizeHandler : Handler
		{
			public override void Handle(string message)
			{
				if (message == "oops")
				{
					Console.WriteLine("Do Authorize");
				}
				else
				{
					base.Handle(message);
				}
			}
		}

		class AutenficationHandler : Handler
		{
			public override void Handle(string message)
			{
				if (message == "opa")
				{
					Console.WriteLine("Do Authorize");
				}
				else
				{
					base.Handle(message);
				}
			}
		}

		static void Main(string[] args)
		{
			Handler authorize = new AuthorizeHandler();
			Handler autenfication = new AutenficationHandler();
			autenfication.AddNext(authorize);
			autenfication.Handle("oops");
		}
	}
}