using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsTest.Products;

namespace PatternsTest
{
	internal interface IAbstarctFactory
	{
		IArmchair GetArmchair();
		ITable GetTable();
		ISofa GetSofa();
	}
}
