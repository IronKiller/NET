using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pubs2.Models
{
    public class Existencia
    {
        public int ExistenciaId { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }


    }
}