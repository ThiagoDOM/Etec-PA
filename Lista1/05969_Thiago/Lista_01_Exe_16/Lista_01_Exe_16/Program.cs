using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoc, porcd, impo, precof;
            Console.Write("Digite o custo de de fábrica do carro: ");
            precoc = double.Parse(Console.ReadLine());
            porcd = precoc * 0.28;
            impo = precoc * 0.45;
            precof = precoc + porcd + impo;
            Console.WriteLine();
            Console.WriteLine("O valor final do carro é: {0:c}", precof);
            Console.ReadKey();

        }
    }
}
