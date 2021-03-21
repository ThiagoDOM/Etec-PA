using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double pag, pr, d;
            Console.Write("Digite o preço do produto: ");
            pr = double.Parse(Console.ReadLine());
            Console.Write("Digite a porcentagem do desconto: ");
            d = double.Parse(Console.ReadLine());
            pag = pr - pr * d / 100;
            Console.WriteLine();
            Console.Write("O valor a ser pago é: {0:c}", pag);
            Console.ReadKey();
        }
    }
}
