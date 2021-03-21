 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, h=0;
            Console.Write("Digte o final da sequência(0, 1, 2, 3, ..., n): ");
            n = int.Parse(Console.ReadLine());
            for (i=1; i<=n; i++)
            {
                Console.WriteLine(i);
                h = h + i;
            }
            Console.WriteLine("A soma dos termos é: {0}", h);
            Console.ReadKey();
        }
    }
}
