using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, p;
            string s;
            Console.Write("Digite a sua altura: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo(masculino/feminino): ");
            s = Console.ReadLine();
            Console.WriteLine();
            if (s == "masculino")
            {
                p = (72.7 * h) - 58;
                Console.Write("Seu peso ideal é: {0}", p);
            }
            else
            {
                p = (62.1 * h) - 44.7;
                Console.Write("Seu peso ideal é: {0}", p);
            }
            Console.ReadKey();
        }
    }
}
