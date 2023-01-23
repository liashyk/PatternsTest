using PatternsTest.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest
{
	class ModernFactory : IAbstarctFactory
	{
		public IArmchair GetArmchair()
		{
			return new ModernArmChair();
		}

		public ISofa GetSofa()
		{
			return new ModernSofa();
		}

		public ITable GetTable()
		{
			return new ModernTable();
		}
	}

	class ArDekoFactory : IAbstarctFactory
	{
		public IArmchair GetArmchair()
		{
			return new ArDekoArmChair();
		}

		public ISofa GetSofa()
		{
			return new ArDekoSofa();
		}

		public ITable GetTable()
		{
			return new ArDekoTable();
		}
	}

	class VictorianFactory : IAbstarctFactory
	{
		public IArmchair GetArmchair()
		{
			return new VictorianArmChair();
		}

		public ISofa GetSofa()
		{
			return new VictorianSofa();
		}

		public ITable GetTable()
		{
			return new VictorianTable();
		}
	}
}
