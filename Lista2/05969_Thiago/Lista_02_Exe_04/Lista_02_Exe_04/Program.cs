using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double vg, ct;
            string tc;
            Console.Write("Digite o tipo de carro(G - gasolina ou A - álcool): ");
            tc = Console.ReadLine();
            Console.Write("Digite a capacidade do tanque de combustível em litros: ");
            ct = double.Parse(Console.ReadLine());
            if (tc == "G")
            {
                vg = ct * 1.8;
                Console.WriteLine("Será gasto: {0:c}", vg);
            }
            else
            {
                vg = ct;
                Console.WriteLine("Será gasto: {0:c}", vg);
            }
            Console.ReadKey();
            
        }
    }
}
