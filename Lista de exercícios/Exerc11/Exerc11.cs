using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double expoente;
            double resultado;

            Console.Write("Insira o número base da potenciação: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o expoente da potenciação: ");
            expoente = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = Math.Pow(numero, expoente);
            Console.WriteLine("O resultado da potenciação é igual a: {0}", resultado);
            Console.ReadKey();

        }
    }
}
