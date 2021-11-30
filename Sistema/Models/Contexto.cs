using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Sistema.Models
{
    public class Contexto: DbContext
    {
      public DbSet<Clientes> Clientes { get; set; }

      public DbSet<Usuarios> Usuarios { get; set; }
    }
}