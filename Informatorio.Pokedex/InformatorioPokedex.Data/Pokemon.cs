using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    class Pokemon
    {
        public string Nombre { get; set; }//Atributos
        public string Alias { get; set; }
        public string Tipo { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }

        public Pokemon(string Name, string Als, string Type, float Weight, float Height)//contructor
        {
            Nombre = Name;//Le estas seteando a Nombre
            Alias = Als;
            Tipo = Type;
            Peso = Weight;
            Altura = Height;
        }
        public void Placaje()
        {
            Console.WriteLine("Usa ataque Placaje!");
        }
        public void Gruñido()
        {
            Console.WriteLine("Usa defensa Placaje!");

        }

    }
}
