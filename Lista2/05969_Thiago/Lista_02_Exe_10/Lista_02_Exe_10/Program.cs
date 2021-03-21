using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s;
            Console.Write("Digite um valor para A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor para B: ");
            b = double.Parse(Console.ReadLine());
            if (a == b)
            {
                s = a + b;
                Console.WriteLine("A soma entre {0} e {1} é: {2}", a, b, s);
            }
            else
            {
                s = a - b;
                if (s < 0)
                {
                    s = s * -1;
                    Console.WriteLine("A diferença entre {0} e {1} é: {2}", a, b, s);
                }
                else
                {
                    Console.WriteLine("A diferença entre {0} e {1} é: {2}", a, b, s);
                }
            }
            Console.ReadKey();
        }
    }
}
