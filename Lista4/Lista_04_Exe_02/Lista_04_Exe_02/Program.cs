using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_04_Exe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numdig = new double[10];
            double soma=0;
            int qtd=0;
            for(int i=0; i < 10; i++)
            {
                Console.Write("Digite o {0} número: ", i + 1);
                numdig[i] = double.Parse(Console.ReadLine());

                if (numdig[i] >60 && numdig[i] < 90)
                {
                    qtd++;
                    soma += numdig[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("A soma de numeros entre 60 e 90 é: {0}", soma);
            Console.WriteLine("A quantidade de números entre 60 e 90 é: {0}", qtd);

            Console.ReadKey();

        }
    }
}
