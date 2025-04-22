using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double raio;
            double area;

            Console.Write("Insira o valor do diâmetro do círculo: ");
            diametro = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            raio = diametro / 2;

            area = 3.14 * (raio * raio);

            Console.WriteLine("O valor da área do círculo é igual a: {0}", area);
            Console.ReadKey();
        }
    }
}
