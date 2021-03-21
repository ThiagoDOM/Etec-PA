using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double q, pr, pt = 0;
            for (int i = 0; i < 45; i++)
            {
                Console.Write("Digite a quantidade do produto {0}: ", i + 1);
                q = double.Parse(Console.ReadLine());
                Console.Write("Digite o preço do produto {0}: ", i + 1);
                pr = double.Parse(Console.ReadLine());
                pt += q * pr;
            }

            Console.Write("Total gasto: {0:C}", pt);
            Console.ReadKey();
        }
    }
}

