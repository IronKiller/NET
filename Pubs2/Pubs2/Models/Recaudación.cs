using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pubs2.Models
{
    public class Recaudación
    {
        public int RecaudaciónId { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
    }
}