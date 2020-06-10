using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_el_valor_absoluto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingrese un numero para obtener su valor absoluto");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("El valor absoluto del numero " + a + " es: " + a);
            }
            else
            {
                b = a * -1;
                Console.WriteLine("El valor absoluto del numero "+ a + " es: "+b);
            }
            Console.ReadKey();
        }
    }
}
