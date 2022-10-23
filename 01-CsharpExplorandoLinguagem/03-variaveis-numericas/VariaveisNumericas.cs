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

            TiposNumericos();

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

        public static object ConversaoNumerica()
        {
            return 0;
        }

        public static void TiposNumericos()
        {
            Console.WriteLine("\n");

            int numero_inteiro = 8000;
            Console.WriteLine("Numero inteiro: " + numero_inteiro);

            float numero_real_com_precisao_menor = 1.60f;
            Console.WriteLine("Numero real com precisão menor: " + numero_real_com_precisao_menor);

            double numero_real = 1.80;
            Console.WriteLine("Numero real: " + numero_real);
            
            long numero_grande = 3000000;
            Console.WriteLine("Numero grande: " + numero_grande);
            
            short numero_pequeno = 1500;
            Console.WriteLine("Numero pequeno: " + numero_pequeno);

            Console.WriteLine("\n");
        }
    }
}
