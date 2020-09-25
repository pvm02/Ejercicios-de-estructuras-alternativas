using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            bool Signo, Cifra;

            Console.WriteLine("Ingrese un numero u signo de puntuacion");
            letra = Convert.ToChar(Console.ReadLine());

            Cifra = (letra >= '0') && (letra <= '9');
            Signo = (letra == '.') || (letra == '_') || (letra == ':') || (letra == ';') || 
            (letra == '?') || (letra == '!') || (letra == '¡') || (letra == ')') || (letra == '(') || 
            (letra == '¿') || (letra == ',') || (letra == '"');

            if (Cifra)
                Console.WriteLine("Es una cifra numérica");
            else if (Signo)
                Console.WriteLine("Es un signo de puntuacion");
            else
                Console.WriteLine("Es otro caracter");
        }

    }

}

        
