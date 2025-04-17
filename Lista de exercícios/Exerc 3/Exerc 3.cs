using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double area;

            Console.Write("Insira o valor da diagonal do quadrado: ");
            diagonal = double.Parse(Console.ReadLine());
            Console.WriteLine();

            area = (diagonal * diagonal) / 2;

            Console.WriteLine("O valor da área do quadrado é: {0}", area);
            Console.ReadKey();

        }
    }
}
