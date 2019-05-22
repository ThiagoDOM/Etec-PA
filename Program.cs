using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, p = 0;
            int op;
            string ex;
            Console.Write("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite mais um número: ");
                n2 = double.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Digite uma opção: (1) Multiplicação, (2) Divisão, (3) Adição ou (4) Subtração: ");
                    op = int.Parse(Console.ReadLine());
                }
                while (op < 1 || op > 4);
                switch (op)
                {
                    case 1:
                        p = n1 * n2;
                        Console.WriteLine("{0} * {1} = {2}", n1, n2, p);
                        break;
                    case 2:
                        p = n1 / n2;
                        Console.WriteLine("{0} / {1} = {2}", n1, n2, p);
                        break;
                    case 3:
                        p = n1 + n2;
                        Console.WriteLine("{0} + {1} = {2}", n1, n2, p);
                        break;
                    case 4:
                        p = n1 - n2;
                        Console.WriteLine("{0} - {1} = {2}", n1, n2, p);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                do
                {
                    Console.Write("Deseja continuar? (S)im ou (N)ão: ");
                    ex = Console.ReadLine().ToLower();
                }
                while (ex != "s" && ex != "n");
                n1 = p;
                Console.Clear();
            }
            while (ex == "s");
        }
    }
}

