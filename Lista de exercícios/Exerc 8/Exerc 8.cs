using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fareinãoseioque;

            Console.Write("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            fareinãoseioque = (celsius * 1.8) + 32;

            Console.WriteLine("O valor em Fahrenheit é: {0}", fareinãoseioque);
            Console.ReadKey();
        }
    }
}
