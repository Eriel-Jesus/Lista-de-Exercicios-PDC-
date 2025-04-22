using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cambio;
            double dolares;
            double reais;

            Console.Write("Insira o valor taxa de câmbio atualmente (real por dólar): ");
            cambio = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira a quantia (em dólares): "); 
            dolares = double.Parse(Console.ReadLine());
            Console.WriteLine();

            reais = dolares * cambio;

            Console.WriteLine("A quantia, em reais, é igual a: {0}", reais);
            Console.ReadKey();

        }
    }
}
