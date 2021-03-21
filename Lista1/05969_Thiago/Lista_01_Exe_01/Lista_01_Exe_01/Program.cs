
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, c, a;
            Console.Write("Digite o comprimento em metros: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura em metros: ");
            l = double.Parse(Console.ReadLine());
            a = l * c;
            Console.WriteLine("A área é: {0}m²", a);
            Console.ReadKey();
        }
    }
}
