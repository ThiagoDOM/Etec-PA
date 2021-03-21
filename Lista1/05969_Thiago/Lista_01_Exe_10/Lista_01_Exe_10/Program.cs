using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Digite um valor inteiro para A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor inteiro para B: ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine();
            Console.WriteLine("A = {0}", a);
            Console.WriteLine("B = {0}", b);
            Console.ReadKey();
        }
    }
}
