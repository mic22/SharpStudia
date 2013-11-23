using System;

namespace zadania_23_listopada
{
	class Tablica
	{
		public static void init ()
		{
			double[,] tab = new double[4, 4];
			for (var i=0; i<tab.GetLength(0); i++)
			{
				for(var j=0; j<tab.GetLength(1); j++)
				{
					tab[i,j]=0;
					Console.Write(tab[i,j]+"\t");
				}
				Console.WriteLine();
			}

		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Tablica.init();
		}
	}
}
