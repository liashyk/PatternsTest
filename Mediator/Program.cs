namespace Mediator
{
	internal class Program
	{
		interface IMediator
		{
			public void Notify(Component sender, string eventName);
		}

		abstract class Component
		{
			protected IMediator? _dialog;

			public Component(IMediator? dialog)
			{
				_dialog = dialog;
			}

			public virtual void Click()
			{
				Console.WriteLine("component was clicked");
			}

		}

		class Button : Component
		{
			public Button(IMediator? dialog) : base(dialog)
			{
			}

			public override void Click()
			{
				Console.WriteLine("button was clicked");
				_dialog.Notify(this, "click");
			}
		}

		class TextField : Component
		{

			public TextField(IMediator? dialog) : base(dialog)
			{
			}

			public override void Click()
			{
				Console.WriteLine("TextField was clicked");
				_dialog.Notify(this, "click");
			}

			public void ShowText()
			{
				Console.WriteLine("text was shown");
			}
		}

		class Dialog : IMediator
		{
			private TextField textField;
			private Button button;

			public Dialog()
			{
				textField = new TextField(this);
				button = new Button(this);
			}

			public void Notify(Component sender, string eventName)
			{
				if(sender== button && eventName=="click") 
				{ 
					textField.ShowText();
				}
			}
		}



		static void Main(string[] args)
		{
		}
	}
}