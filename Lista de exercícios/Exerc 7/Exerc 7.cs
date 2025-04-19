using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhas;
            double kilometros;

            Console.Write("Digite a quantia de milhas marítimas: ");
            milhas = double.Parse(Console.ReadLine());

            kilometros = (milhas * 1852) / 1000;

            Console.WriteLine("A quantia de milhas em kilometros equivale a: {0}", kilometros);
            Console.ReadKey();
        }
    }
}
