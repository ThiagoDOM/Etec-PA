using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, m = 0, i = 0;
            string r;

            Console.Write("Digite o 1º número: ");
            m = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite o {0}º número: ", i + 2);
                n = double.Parse(Console.ReadLine());
                if (n < m && n > 0)
                {
                    m = n;
                }
                do
                {
                    Console.Write("Deseja continuar? S/N: ");
                    r = Console.ReadLine().ToLower();
                }
                while (r != "s" && r != "n");
                i++;
            }
            while (r == "s");
            Console.WriteLine();
            Console.WriteLine("O menor valor é: {0}", m);
            Console.ReadKey();
        }
    }
}
