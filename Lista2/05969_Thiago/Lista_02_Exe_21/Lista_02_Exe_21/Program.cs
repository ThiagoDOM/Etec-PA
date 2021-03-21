using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            Console.Write("Digite a sua idade: ");
            id = int.Parse(Console.ReadLine());
            if (id >= 18)
            {
                Console.Write("Categoria Adulto.");
            }
            else 
            {
                switch (id)
                {
                    case 5:
                    case 6:
                    case 7:
                        Console.Write("Categoria Infantil A.");
                        break;
                    case 8:
                    case 9:
                    case 10:
                        Console.Write("Categoria Infantil B.");
                        break;
                    case 11:
                    case 12:
                    case 13:
                        Console.Write("Categoria Juvenil A.");
                        break;
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                        Console.Write("Categoria Juvenil B.");
                        break;
                    default:
                        Console.Write("Comando desconhecido.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
