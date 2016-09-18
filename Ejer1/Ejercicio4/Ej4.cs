using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ej4
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int num, max, min;

            while (cont < 10)
            {
                Console.WriteLine("Ingresa un número.");
                num = Convert.ToInt16(Console.ReadLine());

                max = num;

                if (num > max)
                {
                    max = num;
                }
                if (num < max)
                {
                    min = num;
                }

                cont = cont + 1;
            }
           
            Console.WriteLine ("El mayor número fue: {0}", max);
            Console.WriteLine("El menor número fue: {0}", min);
        }
    }
}
