using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sua tabuada é: ");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(n * (i+1));
            }
            Console.ReadKey();
        }
    }
}
