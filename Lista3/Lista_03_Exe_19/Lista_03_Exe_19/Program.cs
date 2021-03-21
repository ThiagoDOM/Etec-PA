using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, a=0, b=0, c=0, d=0, e=0, erro;
            double med=0, aux, soma;
            string re;
            char op;
            do
            {
                do
                {
                    Console.Write("Digite sua idade: ");
                    aux = double.Parse(Console.ReadLine());
                } while (aux < 1);
                
                do
                {
                    erro = 0;
                    Console.Write("Digite sua opinião(A-Ótimo;B-Bom;C-Regular;D-Ruim;E-Péssimo): ");
                    op = char.Parse(Console.ReadLine().ToLower());
                    switch (op)
                    {
                        case 'a':
                            a++;
                            break;
                        case 'b':
                            b++;
                            break;
                        case 'c':
                            c++;
                            break;
                        case 'd':
                            d++;
                            break;
                        case 'e':
                            e++;
                            break;
                        default:
                            erro = 1;
                            break;
                    }
                } while (erro == 1);
                med += aux;
                cont++;
                do
                {
                    Console.Write("Adicionar mais pessoas?(S/N): ");
                    re = Console.ReadLine().ToLower();
                } while (re != "s" && re != "n");
                
            } while (re == "s");
            Console.Clear();

            soma = a + b + c + d + e;
            Console.WriteLine("");
            Console.WriteLine("Pessoas ques responderam a pesquisa: {0}", cont);
            Console.WriteLine("");
            Console.WriteLine("Média das idades das pessoas responderam a pesquisa: {0}", med/cont);
            Console.WriteLine("");
            
            Console.WriteLine("A Resposta A teve {0}%", (a / soma) * 100) ;
            Console.WriteLine("A Resposta B teve {0}%", (b / soma) * 100);
            Console.WriteLine("A Resposta C teve {0}%", (c / soma) * 100);
            Console.WriteLine("A Resposta D teve {0}%", (d / soma) * 100);
            Console.WriteLine("A Resposta E teve {0}%", (e / soma) * 100);
            Console.ReadKey();
        }
    }
}
