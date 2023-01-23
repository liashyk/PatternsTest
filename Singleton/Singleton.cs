using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	static class Singleton
	{
		private static Goverment? _goverment;

		public static Goverment GetGoverment()
		{
			if (_goverment == null)
			{
				_goverment = new Goverment();
			}
			return _goverment;
		}

	}
}
