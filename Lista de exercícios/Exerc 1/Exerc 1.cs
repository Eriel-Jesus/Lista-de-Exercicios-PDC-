using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double altura;
            double area;

            Console.Write("Insira o valor da largura do retângulo: ");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o valor da altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            area = largura * altura;

            Console.WriteLine("O valor da área do retângulo é: {0}", area);
            Console.ReadKey();


        }
    }
}
