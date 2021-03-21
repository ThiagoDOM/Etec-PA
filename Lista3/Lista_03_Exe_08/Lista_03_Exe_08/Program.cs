using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, aux, i=0;
            Console.Write("Digite o 1 valor: ");
            n = int.Parse(Console.ReadLine());
            while (i < 19) 
            {
                Console.Write("Digite o {0} valor: ", i + 2);
                aux = int.Parse(Console.ReadLine());
                if (aux > n)
                {
                    n = aux;
                }
                i++;

            }
            Console.WriteLine("O maior valor digitado foi: {0}", n);
            Console.ReadKey();
        }
    }
}
