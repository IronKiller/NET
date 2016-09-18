using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
   public  class ManejoDeDatos
    {
       //agregar pokemons
       //devolver una lista con todos los pokemon registrados hasta el momento
       public void registroDePokemon (string Nombre, string Tipo, string Alias, float Peso, float Altura)
        {
            if (Tipo == "Fuego")
            {
                DatosPokemon.pokemons.Add(new TipoFuego(Nombre, Alias, Tipo, Peso, Altura));
                Console.WriteLine("Registrando Pokémon....espere....");
                Console.WriteLine("Completado.");

            }
            else if (Tipo == "Agua")
            {
                DatosPokemon.pokemons.Add(new TipoAgua(Nombre, Alias, Tipo, Peso, Altura));
                Console.WriteLine("Registrando Pokémon....espere....");
                Console.WriteLine("Completado.");
            }
            else if (Tipo == "Planta")
            {
                DatosPokemon.pokemons.Add(new TipoPlanta(Nombre, Alias, Tipo, Peso, Altura));
                Console.WriteLine("Registrando Pokémon....espere....");
                Console.WriteLine("Completado.");
            }
        }
        
        public void mostrarCapturados()
        {
            foreach( Pokemon PoK in DatosPokemon.pokemons)
            {
                Console.WriteLine(PoK.Nombre);
                Console.WriteLine(PoK.Alias);
                Console.WriteLine(PoK.Tipo);
                Console.WriteLine(PoK.Peso);
                Console.WriteLine(PoK.Altura);

                if (PoK.Tipo == "Fuego")
                {
                    TipoFuego fuego = new TipoFuego(PoK.Nombre, PoK.Alias, PoK.Tipo, PoK.Peso, PoK.Altura);
                    Console.WriteLine(fuego.Lanzallamas());
                }
                else if (PoK.Tipo == "Planta")
                {
                    TipoPlanta planta = new TipoPlanta(PoK.Nombre, PoK.Alias, PoK.Tipo, PoK.Peso, PoK.Altura);
                    Console.WriteLine(planta.LatigoCepa());
                }
                else
                {
                    TipoAgua agua = new TipoAgua(PoK.Nombre, PoK.Alias, PoK.Tipo, PoK.Peso, PoK.Altura);
                    Console.WriteLine(agua.ChorroDeAgua());
                }
            }
        }
    }
}
