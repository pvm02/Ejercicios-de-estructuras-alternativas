using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_alternativas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.WriteLine("Ingrese un numero entero corto");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero entero corto");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine(" El mayor es " + n1);
            else

                if (n2 > n1)
                Console.WriteLine("El mayor es " + n2);
            else
                Console.WriteLine("Ambos numeros son iguales");

            
        }
    }
 }

