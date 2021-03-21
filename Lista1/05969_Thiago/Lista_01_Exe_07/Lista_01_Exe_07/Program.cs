using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double vol, r;
            Console.Write("Digite o raio da esfera em centímetros: ");
            r = double.Parse(Console.ReadLine());
            vol = 4 * 3.14 * (Math.Pow(r, 3)) / 3;
            Console.WriteLine();
            Console.Write("O volume da esfera é: {0}cm³", vol);
            Console.ReadKey();
        }
    }
}
