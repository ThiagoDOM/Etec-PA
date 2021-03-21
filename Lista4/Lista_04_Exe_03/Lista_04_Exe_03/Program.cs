using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_04_Exe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] id = new double[10];
            double[] peso = new double[10];
            double[] alt = new double[10];
            double idmed = 0, porc = 0;
            int qtd = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}ª pessoa", i+1);
                Console.Write("Digite a sua idade: ");
                id[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite o seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite a sua altura: ");
                alt[i] = double.Parse(Console.ReadLine());
                idmed += id[i] / 10;
                if (peso[i] > 90 || alt[i] < 1.5)
                {
                    qtd++;
                }
                if (id[i] >= 10 || id[i] <= 30 || alt[i] > 1.9)
                {
                    porc++;
                }
            }
            porc = porc / 10 * 100;
            Console.WriteLine();
            Console.WriteLine("Há {0} pessoa(s) com mais de 90 quilos.", qtd);
            Console.WriteLine("A média das idades é: {0:F}", idmed);
            Console.ReadKey();
        }
    }
}
