using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pubs2.Models
{
    public class Puesto: Persona
    {
        public int PuestoId { get; set; }
        public Persona Empleado { get; set; }
        public String Cargo { get; set; }
    }
}