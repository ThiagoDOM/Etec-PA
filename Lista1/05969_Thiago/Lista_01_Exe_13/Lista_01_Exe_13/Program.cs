using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, resultado;
            Console.Write("Digite um valor para A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor para B: ");
            b = int.Parse(Console.ReadLine());
            c = (a - b) * a / 3;
            resultado = b - 100;
            Console.WriteLine();
            Console.WriteLine("O resultado da operação foi : {0}", resultado);
            Console.ReadKey();
        }
    }
}
