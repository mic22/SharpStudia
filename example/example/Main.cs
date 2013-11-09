using System;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_z_tablic
{
    class Program
    {
        static void Main (string[] args)
		{
			foreach (var item in args) {
				Console.WriteLine (item);
			};
        }
    }
}