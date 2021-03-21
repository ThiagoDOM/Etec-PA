using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, n, f = 1;
            Console.Write("Digte um número: ");
            n = double.Parse(Console.ReadLine());
            if (n == 0)
            {
                f = 1;
            }
            if (n < 0)
            {
                n = n * -1;
            }

            for (i = 1; i <= n; i++)
            {
   
                f = f * i; 
            }
            Console.WriteLine("O fatorial de {1} é: {0}", f, n);
            Console.ReadKey();
        }
    }
}
