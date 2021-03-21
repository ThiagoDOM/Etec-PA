using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            Console.Write("Digite o preço do produto: ");
            p = double.Parse(Console.ReadLine());
            if (p >= 50)
            {
                if ( p <= 100)
                {
                    Console.WriteLine("Em Promoção!");
                }
                else
                {
                    Console.WriteLine("Preço Normal");
                }
            }
            else
            {
                Console.WriteLine("Preço Normal");
            }
            Console.ReadKey();
        }
    }
}
