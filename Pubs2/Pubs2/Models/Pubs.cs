using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pubs2.Models
{
    public class Pubs
    {
        public int PubsId { get; set; }
        public int LicenciaFiscal { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime Horario { get; set; }

        public List <string> DiasApertura  { get; set; }
        public List <Persona> Titulares { get; set; }
        public List <Puesto> Puestos { get; set; }
        public List <Existencia> Existencias { get; set; }
        public List <Pedido> Pedidos { get; set; }
        public List <Recaudación> Recaudaciones { get; set; }
    }
}