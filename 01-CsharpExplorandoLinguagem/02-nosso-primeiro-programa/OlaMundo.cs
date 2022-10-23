using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CsharpExplorandoLinguagem._02_nosso_primeiro_programa
{
    internal class OlaMundo
    {
        public static void Escreva()
        {
            Helper.Inicio("02 - Nosso primeiro programa");
            Console.WriteLine("Olá, Mundo.");
            Helper.Fim();
        }
    }
}
