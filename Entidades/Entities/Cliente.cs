using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Reserva = new HashSet<Reserva>();
        }

        public string CedulaCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Apellido1Cliente { get; set; }
        public string Apellido2Cliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string CorreoCliente { get; set; }

        public virtual ICollection<Reserva> Reserva { get; set; }
    }

}
