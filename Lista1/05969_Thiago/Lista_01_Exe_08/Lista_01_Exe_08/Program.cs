using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int pag, he, me, hs, ms;
            Console.Write("Digite a hora de entrada: ");
            he = int.Parse(Console.ReadLine());
            Console.Write("Digite o minuto de entrada: ");
            me = int.Parse(Console.ReadLine());
            Console.Write("Digite a hora de saída: ");
            hs = int.Parse(Console.ReadLine());
            Console.Write("Digite o minuto de saída: ");
            ms = int.Parse(Console.ReadLine());
            pag = ((hs - he) * 60 + (ms - me)) / 15;
            Console.WriteLine();
            Console.WriteLine("O valor a ser pago é {0:c}", pag );
            Console.ReadKey();

        }
    }
}
