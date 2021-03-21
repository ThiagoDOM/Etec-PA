using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ARRUMAR
namespace Lista_03_Exe_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double caixa, qtd, pr, vt=0, vec;

            Console.Write("Digite a quantidade de dinheiro existente no caixa: ");
            caixa = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite a quantidade do produto a ser comprado: ");
                qtd = double.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Digite o valor unitario do produto: ");
                    pr = double.Parse(Console.ReadLine());
                } while (pr < 0);
                //ARRUMAR
                vt += pr * qtd;
            } while (qtd >= 0);
            
            vec = caixa * 0.8;
            if (vt > vec)
            {
                vt = (vt + vt * 0.1) / 3;
                Console.WriteLine("Deve ser pago com 10% de juros e parcelado em 3 vezes de: {0}", vt);
            }
            else
            {
                vt = vt - vt * 0.05;
                Console.WriteLine("Deve ser pago à vista com 5% de desconto: {0}", vt);
            }
            Console.ReadKey();
        }
    }
}
