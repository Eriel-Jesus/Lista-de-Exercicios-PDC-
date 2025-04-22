using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto1;
            double produto2;
            double produto3;
            double produto4;
            double produto5;
            double valorpagar;
            double pagamento;

            //Produto 1
            Console.Write("Insira o valor do produto: ");
            produto1 = double.Parse(Console.ReadLine());
            do
            {
                if (produto1 <= 0)
                {
                    Console.WriteLine("Valor incorreto, insira novamente o preço do produto: ");
                    produto1 = double.Parse(Console.ReadLine());
                }
                Console.Clear();
            } while (produto1 <= 0);

            //Produto 2
            Console.Write("Insira o valor do produto: ");
            produto2 = double.Parse(Console.ReadLine());
            do
            {
                if (produto2 <= 0)
                {
                    Console.Write("Valor incorreto, insira novamente o preço do produto: ");
                    produto2 = double.Parse(Console.ReadLine());
                }
                Console.Clear();
            } while (produto2 <= 0);

            //Produto 3
            Console.Write("Insira o valor do produto: ");
            produto3 = double.Parse(Console.ReadLine());
            do
            {
                if (produto3 <= 0)
                {
                    Console.Write("Valor incorreto, insira novamente o preço do produto: ");
                    produto3 = double.Parse(Console.ReadLine());
                }
                Console.Clear();
            } while (produto3 <= 0);

            //Produto 4
            Console.Write("Insira o valor do produto: ");
            produto4 = double.Parse(Console.ReadLine());
            do
            {
                if (produto4 <= 0)
                {
                    Console.Write("Valor incorreto, insira novamente o preço do produto: ");
                    produto4 = double.Parse(Console.ReadLine());
                }
                Console.Clear();
            } while (produto4 <= 0);

            //Produto 5
            Console.Write("Insira o valor do produto: ");
            produto5 = double.Parse(Console.ReadLine());
            do
            {
                if (produto5 <= 0)
                {
                    Console.Write("Valor incorreto, insira novamente o preço do produto: ");
                    produto5 = double.Parse(Console.ReadLine());
                }
                Console.Clear();
            } while (produto5 <= 0);

            valorpagar = produto1 + produto2 + produto3 + produto4 + produto5;

            Console.WriteLine("O valor a pagar: {0}", valorpagar);

            Console.Write("Insira o valor para usar no pagamento: ");
            pagamento = double.Parse(Console.ReadLine());
            Console.WriteLine();
            do
            {
                if (pagamento < valorpagar)
                {
                    Console.Clear();
                    Console.WriteLine("O valor a pagar: {0}", valorpagar);
                    Console.Write("Valor insuficiente. Informe-o novamente: ");
                    pagamento = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            } while (pagamento < valorpagar);

            Console.Clear();
            Console.WriteLine("Muito obrigado pela realização da sua compra!!!");
            Console.WriteLine("Valor do troco: {0}", pagamento - valorpagar + " R$");
            Console.ReadKey();

        }
    }
}
