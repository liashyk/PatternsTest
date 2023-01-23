namespace Prototype
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Airplane airplane1 = new Airplane(2, "red");
			airplane1.MakeTechlogyStuff();
			Airplane airplane2= airplane1.Clone();
			Console.WriteLine($"They are the same object?: {airplane1==airplane2}");
			Console.WriteLine($"They have now same private technology stuff? : " +
				$"{ airplane1.TechnologyStuff==airplane2.TechnologyStuff}");
		}
	}
}