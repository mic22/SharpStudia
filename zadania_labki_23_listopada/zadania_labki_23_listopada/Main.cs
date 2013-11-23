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

	class Complex
	{
		/*
		get, set Im, Re, dodawanie, odejmowanie, dzielenie, mozenie, modul, faza w stopniach
		 */
		private double Re, Im;
		public Complex ()
		{
			this.Re=0;
			this.Im=0;
		}

		public Complex setRe (double _Re)
		{
			this.Re=_Re;
			return this;
		}

		public Complex setIm (double _Im)
		{
			this.Im=_Im;
			return this;
		}

		public double getRe ()
		{
			return this.Re;
		}

		public double getIm ()
		{
			return this.Im;
		}

		public void print()
		{
			if(this.Im>0)
				Console.WriteLine(this.Re+"+"+this.Im+"i");
			else
				Console.WriteLine(this.Re+""+this.Im+"i");
		}

		public double getModulus ()
		{
			return Math.Sqrt ((this.Re*this.Re)+(this.Im*this.Im));
		}

		public double getPhase ()
		{
			if (this.Re > 0)
				return Math.Atan(this.Im/this.Re);
			else if (this.Re < 0)
				return Math.Atan(this.Im/this.Re)+Math.PI;

			return 0;
		}

		public Complex add (Complex c1)
		{
			Complex temp=new Complex();
			temp.setRe (this.Re+c1.getRe());
			temp.setIm (this.Im+c1.getIm());
			return temp;
		}

		public Complex substract (Complex c1)
		{
			Complex temp=new Complex();
			temp.setRe (this.Re-c1.getRe());
			temp.setIm (this.Im-c1.getIm());
			return temp;
		}

		public Complex mulitiply (Complex c1)
		{
			Complex temp=new Complex();
			temp.setRe ((this.Re*c1.getRe())-(this.Im*c1.getIm())).setIm((this.Re*c1.getIm())+(this.Re*c1.getRe()));
			return temp;
		}

		public Complex divide (Complex c1)
		{
			/* NOT IMPLEMENTED YET */
			return new Complex();
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Complex liczba= new Complex();
			Complex liczba2= new Complex();
			Complex liczba3;

			liczba.setRe(10).setIm(2);
			liczba2.setRe(5).setIm(4);

			//liczba3=liczba.add(liczba2);
			//liczba3=liczba.substract(liczba2);
			liczba3=liczba.mulitiply(liczba2);
			//liczba3=liczba.divide(liczba2);

			liczba3.print();
			Console.WriteLine(liczba3.getModulus());
			Console.WriteLine(liczba3.getPhase());
		}
	}
}
