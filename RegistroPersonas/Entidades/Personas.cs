using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPersonas.Entidades
{
    public class Personas
    {
        [Key]
        //ATRIBUTOS DE NUESTRA CLASE
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }

        //LiSTA TIPO TELEFONO-DETALLE
        public virtual List<TelefonoDetalle> Telefono { get; set; }

        //Constructor Con parametros
        public Personas(int idPersona, string nombre, string cedula, string direccion, List<TelefonoDetalle> telefono)
        {
            IdPersona = idPersona;
            Nombre = nombre;
            Cedula = cedula;
            Direccion = direccion;
            Telefono = telefono;
        }

        public Personas()
        {
            IdPersona = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = new List<TelefonoDetalle>();
        }
    }
}
