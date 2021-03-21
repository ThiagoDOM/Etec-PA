using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_04_Exe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] id = new double[7];
            double[] peso = new double[7];
            double idmed=0;
            int qtd=0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Digite sua idade: ");
                id[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                idmed += id[i] / 7;
                if (peso[i] > 90)
                {
                    qtd++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Há {0} pessoa(s) com mais de 90 quilos.", qtd);
            Console.WriteLine("A média das idades é: {0:F}", idmed);
            Console.ReadKey();
        }
    }
}
