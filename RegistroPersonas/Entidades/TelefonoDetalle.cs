using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPersonas.Entidades
{
    public class TelefonoDetalle
    {
        [Key]
        public int TelefonoDetalleId { get; set; }
        public int PersonaId { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }

        public TelefonoDetalle(int telefonoDetalleId, int personaId, string tipoTelefono, string telefono)
        {
            TelefonoDetalleId = telefonoDetalleId;
            PersonaId = personaId;
            TipoTelefono = tipoTelefono;
            Telefono = telefono;
        }

        public TelefonoDetalle()
        {
            TelefonoDetalleId = 0;
            PersonaId = 0;
            TipoTelefono = string.Empty;
            Telefono = string.Empty;
        }
    }
}
