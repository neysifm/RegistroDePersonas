using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPersonas.Entidades;

namespace RegistroPersonas.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Personas> Persona { get; set; }
        public DbSet<TelefonoDetalle> Telefono { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
