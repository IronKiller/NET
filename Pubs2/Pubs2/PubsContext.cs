using Pubs2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pubs2
{
    public class PubsContext : DbContext
    {
        public PubsContext()
            : base()
        {

        }
       
        public DbSet <Pubs> Pubs { get; set; }
        public DbSet <Persona> Personas { get; set; }
        public DbSet <Pedido> Pedidos { get; set; }
        public DbSet <Proveedor> Proveedores { get; set; }
        public DbSet <Puesto> Puestos { get; set; }
        public DbSet <Recaudación> Recaudaciones { get; set; }
        public DbSet <Existencia> Existencias { get; set; }
    }
}