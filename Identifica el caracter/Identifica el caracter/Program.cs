﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifica_el_caracter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            char b,caracter;

            Console.WriteLine("Ingrese un caracter o numero");
            string a = Console.ReadLine();
            int f = a.Length;

            if (f == 1)
            {
                bool isNumeric = int.TryParse(a, out n);
                bool isChar = char.TryParse(a, out b);
                caracter = Convert.ToChar(a);

                if (isNumeric == true)
                {
                    Console.WriteLine("es un numero ");
                }
                else if (isChar == true)
                {
                    if ((caracter == '.') || (caracter == ',') || (caracter == ';') || caracter == ':' ||
                        (caracter == '¿') || (caracter == '?') || (caracter == '!') || (caracter == '¡'))
                    {
                        Console.WriteLine("es signo de puntuacion ");
                    }
                    else
                    {
                        Console.WriteLine("es caracter ");
                    }

                }

            }
            else if (f !=1)
            {
                Console.WriteLine("Por favor solo ingrese un caracter");
            }

            
            Console.ReadKey();
            
        }
    }
}
       