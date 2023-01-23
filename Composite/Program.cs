namespace Composite
{

	internal class Program
	{
		static Box MakeTree()
		{
			var hammer = new Good("hammer", 300);
			var receipt = new Good("receipt", 50);
			var phone = new Good("phone", 1000);
			var earphones = new Good("earphones", 600);
			var charger = new Good("charger", 400);

			var hammerBox = new Box();
			hammerBox.Add(hammer);

			var phoneAndEarphonesBox= new Box();
			phoneAndEarphonesBox.Add(phone);
			phoneAndEarphonesBox.Add(earphones);

			var chargerBox=new Box();
			chargerBox.Add(charger);

			var boxBox = new Box();
			boxBox.Add(phoneAndEarphonesBox);
			boxBox.Add(chargerBox);

			var complexBox=new Box();
			complexBox.Add(hammerBox);
			complexBox.Add(boxBox);
			complexBox.Add(receipt);

			return complexBox;
		}

		static void Main(string[] args)
		{
			Box treeBox= MakeTree();
			Console.WriteLine(treeBox.GetPrice());
		}
	}
}