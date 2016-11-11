using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pubs2.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
    }
}