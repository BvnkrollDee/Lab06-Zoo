using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memphis_Zoo
{
	 class Rhino: Mammal, IWalks
	{
		public int Legs { get; set; }


		public void Walk()
		{
			Console.WriteLine("I have big meaty hooves");
		}
	}
}

