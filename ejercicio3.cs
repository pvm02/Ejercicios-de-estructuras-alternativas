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
			int num;
			int num2;

			Console.WriteLine(" Ingrese un número entero ");
			num = Convert.ToInt32(Console.ReadLine());



			if (num % 10 == 0)
			{

				Console.WriteLine(" El número es multiplo de 10 ");
				Console.WriteLine(" Ingrese un otro número entero ");
				num2 = Convert.ToInt32(Console.ReadLine());

				if (num2 % 10 == 0)
				{

					Console.WriteLine(" El segundo número es multiplo de 10 ");

				}

				else
				{

					Console.WriteLine(" El segundo número no es multiplo de 10 ");
				}


			}


			else
			{

				Console.WriteLine(" El primer numero no es multiplo de 10 ");

			}
		}
	}

}



