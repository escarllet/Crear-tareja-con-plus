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

            Console.WriteLine("Ingrese un caracter");
            string a = Console.ReadLine();
            int f = a.Length;
            if (f==1)
            {
                bool isNumeric = int.TryParse(a, out n);
                bool isChar = char.TryParse(a, out b);
                char[] vocales = {'a','e','i','o','u','A','E','I','O','U'};
                char[] consonantes = {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'ñ', 
                    'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z','B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'Ñ',
                    'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
                char p = Convert.ToChar(a);
                if (isNumeric == true)
                {
                    Console.WriteLine("es un numero ");
                }
                else if (isChar == true)
                {
                    foreach (var item in vocales)
                    {
                        if (p==item)
                        {
                            Console.WriteLine(p+" es una vocal");
                            break;
                        }

                    }
                    foreach (var item in consonantes)
                    {
                        if (p == item)
                        {
                            Console.WriteLine(p + " es una consonante");
                            break;
                        }

                    }


                }
            }
            
            Console.ReadKey();

        }
    }
}
