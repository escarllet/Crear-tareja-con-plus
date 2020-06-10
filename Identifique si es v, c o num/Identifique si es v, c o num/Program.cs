using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifique_si_es_v__c_o_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            char b;

            Console.WriteLine("Ingrese un caracter o numero");
            string a = Console.ReadLine();

            bool isNumeric = int.TryParse(a, out n);
            bool isChar = char.TryParse(a, out b);


            if (isNumeric == true)
            {
                Console.WriteLine("es un numero ");
            }
            else if (isChar == true)
            {
                if (Equals(a, "a"))
                {
                    Console.WriteLine("es vocal ");
                }
                else
                {
                    Console.WriteLine("es consonante ");
                }

            }
            Console.ReadKey();

        }
    }
}
