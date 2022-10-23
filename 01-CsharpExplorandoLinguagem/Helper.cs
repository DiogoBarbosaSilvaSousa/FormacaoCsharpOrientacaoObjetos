using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CsharpExplorandoLinguagem
{
    internal class Helper
    {
        public static void Escreva(string texto = "\n -- -- \n")
        {
            Console.WriteLine("\n" + texto + "\n");
        }

        public static void Inicio(string texto = " -- Início -- ")
        {
            Console.WriteLine("\n" + texto + "\n");
        }

        public static void Fim(string texto = " -- Fim -- ")
        {
            Console.WriteLine("\n" + texto + "\n");
        }

    }
}
