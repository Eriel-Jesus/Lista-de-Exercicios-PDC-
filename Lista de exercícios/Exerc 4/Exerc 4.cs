using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b;
            double h;
            double area;

            Console.Write("Insira o valor da base do triângulo: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o valor da altura do triângulo: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine();

            area = (b * h) / 2;

            Console.WriteLine("O valor da área do triângulo é igual a: {0}", area);
            Console.ReadKey();

        }
    }
}
