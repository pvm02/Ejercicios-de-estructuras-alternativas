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

			Console.WriteLine(" Ingrese el primer número ");
			num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" Ingrese el segundo número ");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (num2 > 0)
		{
				Console.WriteLine(" El resultado de la división de los dos números es: " + num / num2);

			}

			else
		{
				Console.WriteLine(" Error: No se puede dividir entre cero ");

			}

		}
	}
}


