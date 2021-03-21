using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double ht, vh, sb, sl, ir;
            Console.Write("Digite a quantidade do horas trabalhadas: ");
            ht = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da hora trabalhada: ");
            vh = double.Parse(Console.ReadLine());
            sb = vh * ht;

            //INSS
            if (sb <= 2668.15)
            {
                if (sb > 1334.07)
                {
                    sl = sb - sb * 0.11;
                }
                else
                {
                    if (sb > 900.00)
                    {
                        sl = sb - sb * 0.09;
                    }
                    else
                    {
                        if (sb > 800.45)
                        {
                            sl = sb - sb * 0.0865;
                        }
                        else
                        {
                            sl = sb - sb * 0.0765;
                        }
                    }
                }
            }
            else
            {
                sl = sb - 293.5;
            }

            //Imposto de renda
            if (sl > 1257.13 && sl < 2512.08)
            {
                //15%
                ir = 0.15 * sl - 188.57;
                sl = sl - ir;
                Console.Write("O salário liquido é: {0:c}", sl);
            }
            else
            {
                if (sl > 2512.08)
                {
                    //27,5%
                    ir = 0.275 * sl - 502.58;
                    sl = sl - ir;
                    Console.Write("O salário liquido é: {0:c}", sl);
                }
                else
                {
                    Console.Write("O salário liquido é: {0:c}", sl);
                }
            }
            Console.ReadKey();
        }
    }
}
