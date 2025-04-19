using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double media;

            Console.Write("Insira o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            media = Math.Sqrt(valor1 * valor2);

            Console.WriteLine("O valor da média geométrica é: {0}", media);
            Console.ReadKey();

        }
    }
}
