using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, c, a, p;
            Console.Write("Digite o comprimento em metros: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura em metros: ");
            l = double.Parse(Console.ReadLine());
            a = l * c;
            p = l * 2 + c * 2;
            Console.WriteLine("A área é: {0}m²", a);
            Console.WriteLine("O perímetro é: {0}m", p);
            Console.ReadKey();
        }
    }
}
