using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double dc;
            string cs;
            Console.Write("Digite a cor do semáforo(V(vermelho) A(Amarelo) D(Verde): ");
            cs = Console.ReadLine();
            cs = cs.ToUpper();
            Console.Write("Digite a distância do cruzamento: ");
            dc = double.Parse(Console.ReadLine());
            switch (cs)
            {
                case "V":
                    Console.WriteLine("Parar.");
                    break;
                case "A":
                    if (dc >= 5)
                    {
                        Console.WriteLine("Parar.");
                    }
                    else
                    {
                        Console.WriteLine("Passar com cuidado.");
                    }
                    break;
                case "D":
                    Console.WriteLine("Passar.");
                    break;
                default:
                    Console.WriteLine("Comando desconhecido.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
