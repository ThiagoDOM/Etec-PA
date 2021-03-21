using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, pr;
            Console.Write("Digite o preço do produto: ");
            pr = double.Parse(Console.ReadLine());
            d = pr * 0.05;
            Console.WriteLine();
            Console.Write("O valor do desconto é: {0:c}", d);
            Console.ReadKey();
        
        }
    }
}
