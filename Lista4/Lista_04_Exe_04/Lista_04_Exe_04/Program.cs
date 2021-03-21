using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_04_Exe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] id = new int[12];
            int idmed=0, idmedF=0, idmedM=0, contM=0, contF=0;
            string re;
            for (int i=0; i < 12; i++)
            {
                Console.Write("Digite a {0}ª idade: ", i+1);
                id[i] = int.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Qual é o seu sexo(M/F)?");
                    re = Console.ReadLine().ToLower();
                } while (re != "m" && re != "f");
                
                if( re == "m")
                {
                    contM++;
                }
                if ( re == "f")
                {
                    contF++;
                }
                
            }
            for (int i=0; i < 12; i++)
            {
                idmed += id[i] / 12;
                if (contM > 0)
                {
                    idmedM += id[i] / contM;
                }
                if (contF > 0)
                {
                    idmedF +=  id[i] / contF;
                }
                    
            }
            
            Console.WriteLine();
            Console.WriteLine("A idade média do grupo é: {0}", idmed);
            Console.WriteLine("A idade média dos homens é: {0}", idmedM);
            Console.WriteLine("A idade média das mulheres é: {0}", idmedF);
            Console.ReadKey();

        }
    }
}
