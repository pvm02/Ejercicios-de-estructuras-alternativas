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

            char letra;
            bool Vocal, Cifra;

            Console.WriteLine("Ingrese una letra o numero");
            letra = Convert.ToChar(Console.ReadLine());

            Cifra = (letra >= '0') && (letra <= '9');
            Vocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u');

            if (Cifra)
                Console.WriteLine("Es una cifra numérica");
            else if (Vocal)
                Console.WriteLine("Es una vocal");
            else
                Console.WriteLine("Es una consonante");
        }

    }
}
