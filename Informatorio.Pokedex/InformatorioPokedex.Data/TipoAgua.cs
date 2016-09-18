using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    class TipoAgua:Pokemon
    {
        public TipoAgua(string Name, string Als, string Type, float Weight, float Height):base(Name,Als,Type,Weight,Height)//se llama con heredación, y le asigna con :base al contructor
        {

        }
        public string ChorroDeAgua()
        {
            return "H20 Biatch!";
        }
    }
}
