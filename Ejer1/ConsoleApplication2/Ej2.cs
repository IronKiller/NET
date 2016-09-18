using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Ej2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número del 1 al 7, el programa dirá a que dia de la semana corresponde.");
            int num = Convert.ToInt16(Console.ReadLine());

            if (num ==1)
            {
                Console.WriteLine("Corresponde a Lunes.");
            }
            if (num == 2)
            {
                Console.WriteLine("Corresponde a Martes.");
            }
            if (num ==3)
            {
                Console.WriteLine("Correspone a Miércoles.");
            }
            if (num==4)
            {
                Console.WriteLine("Corresponde a Jueves. (El día de Thor :D )");
            }
            if (num==5)
            {
                Console.WriteLine("Corresponde a Viernes.");
            }
            if (num == 6)
            {
                Console.WriteLine("Corresponde a Sábado.");
            }
            if (num == 7)
            {
                Console.WriteLine("Corresponde a Domingo.");
            }
        }
    }
}
