using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ej3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int num = Convert.ToInt16 (Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int num3 = Convert.ToInt16(Console.ReadLine());

            if (num < num2 & num2 < num3)
            {
                Console.WriteLine("Se han ingresado en orden creciente.");
            }
            else
            {
                Console.WriteLine("Se ingresaron de cualquier forma.");
            }
        }
    }
}
