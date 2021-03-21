using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, m = 0, i = 0;
            do
            {
                Console.Write("Digite um número: ");
                n = double.Parse(Console.ReadLine());
                if (n > m)
                {
                    m = n;
                }

                i++;
            }
            while (n > 0);
            Console.WriteLine("O maior valor é: {0}", m);
            Console.ReadKey();
        }
    }
}
