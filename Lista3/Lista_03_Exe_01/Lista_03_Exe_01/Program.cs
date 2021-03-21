using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, pt=0;
            
            for (int i = 1; i <= 25; i++)
            {
                Console.Write("Digite o peso da caixa {0}: ", i);
                p = double.Parse(Console.ReadLine());
                pt += p;
            }
            Console.Write("O caminhão irá carregar: {0}", pt);
            Console.ReadKey();
        }
    }
}
