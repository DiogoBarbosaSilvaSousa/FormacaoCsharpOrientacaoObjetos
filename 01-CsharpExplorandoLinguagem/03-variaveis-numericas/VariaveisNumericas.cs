using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CsharpExplorandoLinguagem._03_variaveis_numericas
{
    internal class VariaveisNumericas
    {
        public static void Escreva()
        {
            Helper.Inicio("03 - Variáveis numéricas");

            int idade;
            idade = VariavelInteira(36);
            Console.WriteLine("A idade é " + idade);

            double salario;
            salario = VariavelPontoFlutuante(4600.5);            
            Console.WriteLine("O salário é " + salario);

            Helper.Fim();
        }

        public static int VariavelInteira(int numero_int = 0)
        {
            int numero;
            numero = numero_int;
            return numero;
        }

        public static double VariavelPontoFlutuante(double numero_double = 0)
        {
            double numero;
            numero = numero_double;
            return numero;
        }
    }
}
