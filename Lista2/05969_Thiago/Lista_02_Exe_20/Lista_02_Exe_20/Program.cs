using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3, s12, s13, s23;
            Console.Write("Digite o primeiro lado ");
            l1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo lado ");
            l2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro lado ");
            l3 = double.Parse(Console.ReadLine());
            s12 = l1 + l2;
            s13 = l1 + l3;
            s23 = l2 + l3;
            if (s12 > l3 && s13 > l2 && s23 > l1)
            {
                if (l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("É um triângulo equilatero.");
                }
                else
                {
                    if (l1 != l2 && l1 != l3 && l2 != l3)
                    {
                        Console.WriteLine("É um triângulo escaleno.");
                    }
                    else
                    {
                        Console.WriteLine("É um triângulo isósceles.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo.");
            }
            Console.ReadKey();
        }
    }
}
