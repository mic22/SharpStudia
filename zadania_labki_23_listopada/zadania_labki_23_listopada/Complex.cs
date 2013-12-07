using System;

namespace zadania_labki_23_listopada
{
	public class Complex
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

		private double degToRad(double angle)
		{
			return angle*(180.0/Math.PI);
		}

		public double getPhase ()
		{
			if (this.Re > 0)
				return this.degToRad (Math.Atan(this.Im/this.Re));
			else if (this.Re < 0)
				return this.degToRad (Math.Atan(this.Im/this.Re)+Math.PI);

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
			temp.setRe((this.Re*c1.getRe())-(this.Im*c1.getIm())).setIm((this.Re*c1.getIm())+(this.Re*c1.getRe()));
			return temp;
		}

		public Complex divide (Complex c1)
		{
			Complex temp=new Complex();
			double divider=(c1.getRe()*c1.getRe())+(c1.getIm()*c1.getIm());
			temp.setRe(((this.Re*c1.getRe())+(this.Im*c1.getIm()))/divider);
			temp.setIm(((this.Im*c1.getRe())-(this.Re*c1.getIm()))/divider);
			return temp;
		}
	}
}

