﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    class TipoFuego:Pokemon
    {
        public TipoFuego(string Name, string Als, string Type, float Weight, float Height) : base(Name, Als, Type, Weight, Height)
        {

        }
        public string Lanzallamas()
        {
            return "Lanzallamas!";
        }    
    }
}
