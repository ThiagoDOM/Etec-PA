using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double a=0, l, c;
            string re;
            do
            {
                Console.Write("Digite a largura do comodo {0} em metros: ", i+1);
                l = double.Parse(Console.ReadLine());
                Console.Write("Digite o comprimento do comodo {0} em metros: ", i+1);
                c = double.Parse(Console.ReadLine());
                a += l * c;
                i++;
                do
                {
                    Console.Write("Deseja adicionar mais algum comodo?(S/N): ");
                    re = Console.ReadLine().ToLower();
                } while (re != "s" && re != "n");

            } while (re == "s");
            Console.Write("A área total é : {0}m²", a);
            Console.ReadKey();
        }
    }
}
