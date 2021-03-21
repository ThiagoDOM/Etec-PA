using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double ht, sb, vh, sl, ins, imp;
            string re;
            do
            {
                Console.Clear();
                Console.Write("Digite o valor da hora trabalhada: ");
                vh = double.Parse(Console.ReadLine());

                Console.Write("Digite as horas trabalhadas: ");
                ht = double.Parse(Console.ReadLine());

                sb = ht * vh;
                ins = sb * 0.11;
                sl = sb - ins;
                if (sl > 1800)
                {
                    imp = sl * 0.275;
                    sl = sl - imp;
                }
                else
                {
                    if (sl >= 900 && sl <= 1800)
                    {
                        imp = sl * 0.15;
                        sl = sl - imp;
                    }
                }


                Console.WriteLine("Seu salário líquido é: {0:C}", sl);
                Console.WriteLine("");
                do
                {
                    Console.Write("Deseja calcular de outro funcionário?(S/N)");
                    re = Console.ReadLine();
                } while (re != "s" && re != "n");
                
            } while (re == "s");

        }
    }
}
