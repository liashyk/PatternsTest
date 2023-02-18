namespace Command
{
	internal class Program
	{
		interface ICommand
		{
			public void Execute();
		}

		class ConcretteComand:ICommand
		{
			private string _parameteres;

			private Receiver _receiver;

			public ConcretteComand(string parameteres, Receiver receiver)
			{
				_parameteres= parameteres;
				_receiver= receiver;
			}

			public void Execute()
			{
				_receiver.MakeSomething();
				_receiver.MakeAnything();
				Console.WriteLine(_parameteres);
			}
		}

		class SecondComand : ICommand
		{
			private Receiver _receiver;
			public SecondComand(Receiver receiver)
			{
				_receiver= receiver;
			}
			public void Execute()
			{
				_receiver.MakeSomething();
			}
		}

		class Receiver
		{
			public void MakeSomething()
			{
				Console.WriteLine("make smth");
			}

			public void MakeAnything()
			{
				Console.WriteLine("make anything");
			}
		}

		class Invoker
		{
			private ICommand _command;
			public void SetCommand(ICommand command)
			{
				_command = command;
			}

			public void ExecuteComand()
			{
				_command.Execute();
			}
		}

		static void Main(string[] args)
		{
			var invoker = new Invoker();
			var receiver = new Receiver();
			ICommand command1 = new ConcretteComand("oops", receiver);
			ICommand command2 = new SecondComand(receiver);
			invoker.SetCommand(command1);
			invoker.ExecuteComand();
			Console.WriteLine("////////");
			invoker.SetCommand(command2);
			invoker.ExecuteComand();

		}
	}
}