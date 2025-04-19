using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;
            double valor4;
            double media;

            Console.Write("Informe o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe o terceiro valor: ");
            valor3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe o quarto valor: ");
            valor4 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            media = (valor1 + valor2 + valor3 + valor4) / 4;
            Console.WriteLine("O valor dá média é igual a: {0}", media);
            Console.ReadKey();

        }
    }
}
