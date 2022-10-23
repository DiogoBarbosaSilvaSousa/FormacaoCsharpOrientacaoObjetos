using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CsharpExplorandoLinguagem._01_historia_e_ecossistema
{
    internal class Historia
    {
        public static void Escreva()
        {
            Helper.Inicio("01 - História e ecossistema da linguagem");

            Console.WriteLine("C# é uma linguagem muito poderosa. \n\n" +
                              "Com ela, podemos fazer aplicações em sistemas para WEB (Web Sites ou Web Apps) e em sistemas puramente \"server-side\" (o famoso back-end), \n" +
                              "além de aplicativos móveis, aplicativos de desktop e até mesmo jogos de console, como o Xbox. \n\n" +
                              "Conseguimos aplicar essa linguagem em diversas áreas e tudo que aprenderemos neste treinamento dará base para nos aprofundarmos nesses assuntos, \n" +
                              "prosseguindo para programação orientada a objetos, por exemplo.");

            Helper.Fim();
        }
    }
}
