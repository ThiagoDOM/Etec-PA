using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double pr;
            int co;
            Console.Write("Digite o valor do produto: ");
            pr = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código da procedência do produto: ");
            Console.WriteLine("1. Sul");
            Console.WriteLine("2. Sudeste");
            Console.WriteLine("3. Centro-Oeste");
            Console.WriteLine("4. Norte");
            Console.WriteLine("5. Nordeste");
            co = int.Parse(Console.ReadLine());
            switch (co)
            {
                case 1:
                    Console.WriteLine("O produto custa {0:c} e sua procedência é o Sul.", pr);
                    break;
                case 2:
                    Console.WriteLine("O produto custa {0:c} e sua procedência é o Sudeste.", pr);
                    break;
                case 3:
                    Console.WriteLine("O produto custa {0:c} e sua procedência é o Centro-Oeste.", pr);
                    break;
                case 4:
                    Console.WriteLine("O produto custa {0:c} e sua procedência é o Norte.", pr);
                    break;
                case 5:
                    Console.WriteLine("O produto custa {0:c} e sua procedência é o Nordeste.", pr);
                    break;
                default:
                    Console.WriteLine("Comando desconhecido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
