using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estucturas_alternativas
{
    class Program
    {
        static void Main(string[] args)
        {

			int num;
			int num2;
			int num3;

			Console.WriteLine(" Ingrese el primer numero ");
			num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" Ingrese el segundo numero ");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" Ingrese el tercer número ");
			num3 = Convert.ToInt32(Console.ReadLine());

			if (num > num2)

			{
				if (num > num3)
				{
					Console.WriteLine(" El primer numero es mayor ");
				}

			}


			else if (num2 > num && num2 > num3)

			{
				Console.WriteLine(" El segundo numero es mayor ");

			}
			else if (num3 > num && num3 > num2)
			{
				Console.WriteLine(" El tercer número es mayor ");
			}
		}
	}
}
