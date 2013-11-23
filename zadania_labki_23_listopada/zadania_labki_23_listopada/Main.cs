using System;

namespace zadania_labki_23_listopada
{
	class Tablica3W
	{
		private int[,,] data;
		private Random random;

		public Tablica3W(int p=1, int r=1, int c=1)
		{
			this.random=new Random();

			this.data=new int[p,r,c];
			this.initialize();
		}

		private void initialize ()
		{
			for (int i=0; i<this.data.GetLength(0); i++)
			{
				for(int j=0; j<this.data.GetLength(1); j++)
				{
					for(int k=0; k<this.data.GetLength(2); k++)
					{
						this.data[i,j,k]=random.Next(1,30);
					}
				}
			}
		}

		public void render (bool verbose=false)
		{
			for (int i=0; i<this.data.GetLength(0); i++)
			{
				if(verbose) Console.WriteLine("Page: "+i);
				for(int j=0; j<this.data.GetLength(1); j++)
				{
					for(int k=0; k<this.data.GetLength(2); k++)
					{
						Console.Write (this.data[i,j,k]+"\t");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
			}
		}
	}

	class Tablica3Wa
	{
		private Random random;
		private int[][][] data;

		public Tablica3Wa (int p=1, int r=1, int c=1)
		{
			this.random=new Random();
			this.initialize(p, r, c);
		}

		private void initialize (int p=1, int r=1, int c=1)
		{
			this.data = new int[p][][];
			for (int i=0; i<p; i++)
			{
				this.data[i]=new int[r][];
				for(int j=0; j<r; j++)
				{
					this.data[i][j]=new int[c];
					for(int k=0; k<c; k++)
					{
						this.data[i][j][k]=this.random.Next(1,30);
					}
				}
			}
		}

		public void render (bool verbose=false)
		{
			for (int i=0; i<this.data.GetLength(0); i++)
			{
				if(verbose) Console.WriteLine("Page: "+i);
				for(int j=0; j<this.data[i].GetLength(0); j++)
				{
					for(int k=0; k<this.data[i][j].GetLength(0); k++)
					{
						Console.Write(this.data[i][j][k]+"\t");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			//Tablica3W tab=new Tablica3W(2, 3, 3);
			//tab.render(true);

			Tablica3Wa tab1=new Tablica3Wa(2, 3, 3);
			tab1.render(true);
		}
	}
}
