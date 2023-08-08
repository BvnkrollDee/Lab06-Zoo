using System;
namespace Memphis_Zoo
{
	 class Godzilla: Reptile, IWalks
	{

		public int Legs { get; set; }


		public void Walk()
		{
			Console.WriteLine("LOOK IT'S GODZILLAAAAAA");
		}
	}
}

