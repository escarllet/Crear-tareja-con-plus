using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_pares_del_23_al_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;

            while (a>=7)
            {
                if (a%2==0)
                {
                    Console.WriteLine(a);
                }
                if (a<=7)
                {
                    break;
                }
                a -= 1;
            }
        }
    }
}
