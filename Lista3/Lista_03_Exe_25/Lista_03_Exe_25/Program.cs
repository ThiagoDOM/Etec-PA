using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int pag, he, me, hs, ms, dh, dm;
            do
            {
                Console.Write("Digite a hora da entrada: ");
                he = int.Parse(Console.ReadLine());
            } while (he < 1 || he > 23);
            do
            {
                Console.Write("Digite o minuto da entrada: ");
                me = int.Parse(Console.ReadLine());
            } while (me < 1 || me > 59);
            do
            {
                Console.Write("Digite a hora da saída: ");
                hs = int.Parse(Console.ReadLine());
            } while (hs < 1 || hs > 23);
            do
            {
                Console.Write("Digite o minuto da saída: ");
                ms = int.Parse(Console.ReadLine());
            } while (ms < 1 || ms > 59);

            dh = hs - he;
            dm = ms - me;
            if (dm > 0)
            {
                dh = dh + 1;
                pag = dh * 4;
                //Console.Write("O valor a ser pago é: {0:C}", pag);
            }
            else
            {
                if (dm == 0)
                {
                    pag = dh * 4;
                }
                else
                {
                    dh = dh - 1;
                    pag = dh * 4;
                }
            }
            switch (dh)
            {
                case 1:
                    Console.Write("O valor a ser pago é: R$ 4,00");
                    break;
                case 2:
                    Console.Write("O valor a ser pago é: R$ 6,00");
                    break;
                default:
                    pag = 4 + dh; // pag = 6 + dh - 2
                    Console.Write("O valor a ser pago é: {0:C}", pag);
                    break;
            }
            Console.ReadKey();
        }
    }
}


