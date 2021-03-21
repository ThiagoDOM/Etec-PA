using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int pag, he, me, hs, ms, dh, dm;
            Console.Write("Digite a hora da entrada: ");
            he = int.Parse(Console.ReadLine());
            Console.Write("Digite o minuto da entrada: ");
            me = int.Parse(Console.ReadLine());
            Console.Write("Digite a hora da saída: ");
            hs = int.Parse(Console.ReadLine());
            Console.Write("Digite o minuto da saída: ");
            ms = int.Parse(Console.ReadLine());
            dh = hs - he;
            dm = ms - me;
            if (dm > 0)
            {
                dh = dh + 1;
                pag = dh * 4;
                Console.Write("O valor a ser pago é: {0:C}", pag);
            }
            else
            {
                if (dm == 0)
                {
                    pag = dh * 4;
                    Console.Write("O valor a ser pago é: {0:C}", pag);
                }
                else
                {
                    dh = dh - 1;
                    pag = dh * 4;
                    Console.Write("O valor a ser pago é: {0:C}", pag);
                }
            }
            Console.ReadKey();
        }
    }
}
