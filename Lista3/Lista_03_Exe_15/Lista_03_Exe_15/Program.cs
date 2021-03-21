using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, res;
            string r;
            do
            {
                do
                {
                    Console.Write("Digite um número: ");
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    res = n % 2;
                    if (res == 0)
                    {
                        Console.WriteLine("{0} é par.", n);
                    }
                    else
                    {
                        Console.WriteLine("{0} é ímpar.", n);
                    }
                    Console.WriteLine();
                } while (n < 0);
                do
                {
                    Console.Write("Deseja continuar?(S/N): ");
                    r = Console.ReadLine().ToLower();
                } while (r != "s" && r != "n");
                
            } while (r == "s");

        }
    }
}
