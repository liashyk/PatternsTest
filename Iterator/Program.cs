namespace Iterator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var spisok = new Spisok<int>();
			spisok.Add(1);
			spisok.Add(2);
			spisok.Add(3);
			spisok.Add(4);
			spisok.Add(5);
			foreach(var item in spisok)
			{
				Console.WriteLine(item);
			}
		}
	}
}