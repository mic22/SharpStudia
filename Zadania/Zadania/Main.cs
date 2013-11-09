using System;

namespace Zadania
{
	class ArrayUtils
	{
		private static Random random=new Random();
		public static double[,] generate (int _x, int _y)
		{
			double[,] data = new double[_x, _y];
			for (int i=0; i<_x; i++) {
				for (int j=0; j<_y; j++) {
					data [i, j] = random.Next (0, 99);
				}
			}
			return data;
		}
		public static double[] generate (int _x)
		{
			double[] data = new double[_x];
			for (int i=0; i<_x; i++) {
				data [i] = random.Next (0, 99);
			}
			return data;
		}
		public static void display (double[,] data)
		{
			for(int i=0; i<data.GetLength(0); i++)
			{
				for(int j=0; j<data.GetLength(1); j++)
				{
					Console.Write (data[i,j]+"\t");
				}
				Console.WriteLine("");
			}
			Console.WriteLine("");
		}
		public static void display (double[] data)
		{
			for(int i=0; i<data.GetLength(0); i++)
			{
				Console.Write (data[i]+"\t");
			}
			Console.WriteLine("");
		}
		public static double getScalar (double[] data1, double[] data2)
		{
			double tmp=0;

			for (int i=0; i<data1.Length; i++)
			{
				tmp+=data1[i]*data2[i];
			}

			return tmp;
		}

		public static double getMatrixTrace (double[,] data)
		{
			if (data.GetLength (0) != data.GetLength (1)) {
				Console.WriteLine ("tablica nie jest kwadratowa");
				return 0;
			}

			double trace=0;

			for(int i=0; i<data.GetLength(0); i++)
			{
				trace+=data[i,i];
			}

			return trace;
		}

		public static void getStats (double [,] data, out double _min, out double _max, out double _avg)
		{
			double min=data[0,0];
			double max=data[0,0];
			double sum=0;

			for (int i=0; i<data.GetLength(0); i++)
			{
				for (int j=0; j<data.GetLength(1); j++)
				{
					min=(data[i,j]<min)?data[i,j]:min;
					max=(data[i,j]>max)?data[i,j]:max;
					sum+=data[i,j];
				}
			}

			_min=min;
			_max=max;
			_avg=sum/data.Length;
		}

		//zadnie kolejne: zortowanie macierzy w wierszach lub kolumnach
		//typ ma byc opcjonalnym parametrem enum
		public static void sort (ref double[,] data, bool row=true)
		{
			if (row)
			{
				for (int i=0; i<data.GetLength(0); i++)
				{
					display (data[i]);//wat?
				}
			}
			else
			{

			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			double [,] test1, test2;
			double [] test3, test4;

			test1=ArrayUtils.generate(5,10);
			test2=ArrayUtils.generate(2, 2);
			test3=ArrayUtils.generate(2);
			test4=ArrayUtils.generate(2);

			Console.WriteLine("trace: "+ArrayUtils.getMatrixTrace(test2));
			Console.WriteLine("scalar: "+ArrayUtils.getScalar(test3, test4));

			double min, max, avg;
			ArrayUtils.getStats(test1, out min, out max, out avg);
			Console.WriteLine("min: "+min+"; max: "+max+"; avg: "+avg);

			ArrayUtils.display(test1);
			ArrayUtils.sort(ref test1, true);//tu wat
			ArrayUtils.display(test1);

		}
		//napisa funkcje obl sume elementow w macierzy NA i pod gl przekatna
		//metoda obl norme z macierzy
		//metody albo klase ktora bedzie rozwizywac dowolny uklad rownan liniowych np. metoda elim. gaussa, rozkladu nu ect
		//
	}
}
