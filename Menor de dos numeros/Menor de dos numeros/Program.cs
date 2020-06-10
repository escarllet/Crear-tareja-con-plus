using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingrese un numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine(a + " es mayor");
            }
            else if (b>a)
            {
                Console.WriteLine(b + " es mayor");
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }
            Console.ReadKey();
        }
    }
}
