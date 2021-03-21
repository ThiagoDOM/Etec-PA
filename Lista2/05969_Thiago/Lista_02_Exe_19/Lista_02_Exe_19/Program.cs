using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int dn, mn, an, id, dm, dd, ah, mh, dh, td;
            Console.Write("Digite o dia do seu nascimento: ");
            dn = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês do seu nascimento: ");
            mn = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano do seu nascimento: ");
            an = int.Parse(Console.ReadLine());
            DateTime date = DateTime.Today;
            ah = date.Year;
            mh = date.Month;
            dh = date.Day;
            id = ah - an;
            dd = dh - dn;
            dm = mh - mn;
            Console.WriteLine();
            if (dd < 0 || dm < 0)
            {
                if (dm < 0)
                {
                    id = id - 1;
                    dd = dd * -1;
                    dm = 12 + dm;
                }
                else
                {
                    id = id - 1;
                    dd = dd * -1;
                    dd = 31 - dd;
                    dm = 11 + dm;
                }

                if (dm == 12)
                {
                    dm = 0;
                    id = id + 1;
                }

                if (dd < 0)
                {
                    dd = dd * -1;
                }
                Console.WriteLine("Sua idade é: {0} anos, {1} meses e {2} dias.", id, dm, dd);
            }
            else
            {
                Console.WriteLine("Sua idade é: {0} anos, {1} meses e {2} dias.", id, dm, dd);
            }
            Console.ReadKey();
        }
    }
}
