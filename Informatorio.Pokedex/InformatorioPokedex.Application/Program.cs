using InformatorioPokedex.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InformatorioPokedex.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokedex = new Pokedex();
            Console.WriteLine("Bienvenido a tu Pokédex!");
            Console.WriteLine("¿Quieres registrar un Pokémon o Ver la Lista de los capturados?");
            Console.WriteLine("");
            Console.WriteLine("...");
            string opt = Console.ReadLine();

            if (opt == "Registrar")
            {
                Console.WriteLine("\nRegistrar Pokémon.");
                Console.WriteLine("¿A cual de estos Pokémons quieres registrar?");
                Console.WriteLine("\n\n1 - Bulbasaur.");
                Console.WriteLine("2 - Squirtle.");
                Console.WriteLine("3 - Charmander.");
                string op = Console.ReadLine();
            }
            else if (opt == "Ver Lista")
            {
                Console.WriteLine("asdas");
            }
            else
            {
                Console.WriteLine("¡Debes ingresar una opción válida!");
                Console.ReadKey();
            }

        }
    }
}
