using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ej1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido.");
            Console.WriteLine("Escribe un número, y el programa te dirá si es par o no.");
            int num = Convert.ToInt16 (Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("El número es par.");
            }
            else
                {
                Console.WriteLine("El Número es impar.");
                }
                
        }
    }
}
