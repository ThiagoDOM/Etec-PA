using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, aux, m, i = 1;
            Console.Write("Digite o 1 valor: ");
            m = int.Parse(Console.ReadLine());
            n = m;
            while (i < 20)
            {
                Console.Write("Digite o {0} valor: ", i + 1);
                aux = int.Parse(Console.ReadLine());
                if (aux > m && aux > n)
                {
                    n = aux;
                }

                if (aux < m)
                {
                    m = aux;
                }
                i++;
            }
            Console.WriteLine("O maior valor digitado foi: {0}", n);
            Console.WriteLine("O menor valor digitado foi: {0}", m);
            Console.ReadKey();
        }
    }
}
