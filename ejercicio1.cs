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

			Console.WriteLine(" Ingrese un número entero ");
			num = Convert.ToInt16(Console.ReadLine());

			if (num % 2 == 0)
			{

				Console.WriteLine(" El número es par ");

			}

			else
			{
				Console.WriteLine(" El número es impar ");

			}
		}

	}

}



