using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memphis_Zoo
{
	 class Gecko: Reptile, IWalks
	{

		public int Legs { get; set; }

		public void Walk()
		{
			Console.WriteLine("15 minutes could save you 15 percent or more on car insurance");
		}
	}
}

