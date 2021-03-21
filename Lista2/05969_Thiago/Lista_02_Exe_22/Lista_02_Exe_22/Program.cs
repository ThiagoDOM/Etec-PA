using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int cp;
            Console.Write("Digite o código do produto: ");
            cp = int.Parse(Console.ReadLine());
            switch (cp)
            {
                case 1:
                    Console.WriteLine("Alimento não perecível.");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Alimento perecível.");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Vestuário.");
                    break;
                case 7:
                    Console.WriteLine("Higiene Pessoal.");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Limpeza e Utensílios Domésticos.");
                    break;
                default:
                    Console.WriteLine("Comando desconhecido.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
