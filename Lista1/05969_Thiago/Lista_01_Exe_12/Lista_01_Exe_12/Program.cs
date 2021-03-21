using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = 2;
            b = 4;
            c = (a + b) * b;
            d = c * b / (a * a);
            a = d / (c + b);
            b = b + a;
            Console.WriteLine("A variavel A vale: {0}", a);
            Console.WriteLine("A variavel B vale: {0}", b);
            Console.WriteLine("A variavel C vale: {0}", c);
            Console.WriteLine("A variavel D vale: {0}", d);
            Console.ReadKey();
        }
    }
}
