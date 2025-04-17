using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aresta;
            double area;

            Console.Write("Insira o valor da aresta do quadrado: ");
            aresta = double.Parse(Console.ReadLine());
            Console.WriteLine();

            area = aresta * aresta;

            Console.WriteLine("O valor da área do quadrado é igual a: {0}", area);
            Console.ReadKey();
        }
    }
}
