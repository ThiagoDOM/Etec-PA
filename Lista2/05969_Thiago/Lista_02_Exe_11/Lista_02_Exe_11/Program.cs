using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string cl;
            Console.Write("Digite o código do livro: ");
            cl = Console.ReadLine();
            cl = cl.ToUpper();
            switch (cl)
            {
                case "A":
                    Console.WriteLine("Ficção.");
                    break;
                case "B":
                    Console.WriteLine("Não-Ficção.");
                    break;
                default:
                    Console.WriteLine("Inválido.");
                    break;

            }
            Console.ReadKey();
        }
    }
}
