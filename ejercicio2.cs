using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1
{
    class Program
    {

        static void Main(string[] args)
        {
			int num2;


			Console.WriteLine(" Ingrese el primer numero entero ");
			num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" Ingrese el segundo número entero ");
			num2 = Convert.ToInt32(Console.ReadLine());



			if (num % num2 == 0)
			{

				Console.WriteLine(" El primer numero es multiplo del segundo ");

			}

			else
			{
				Console.WriteLine(" El primer numero no es multiplo del segundo ");

			}

		}

	}
}







