using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double cl;
            Console.Write("Digite o valor da conta de luz: ");
            cl = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (cl > 50)
            {
                Console.Write("Você está gastando muito.");
            }
            else
            {
                Console.Write("Seu gasto foi normal.");
            }
            Console.ReadKey();
        }
    }
}
