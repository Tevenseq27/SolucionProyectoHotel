using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Reserva
    {
        public short IdReserva { get; set; }
        public string CodReserva { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public short CantidadAdultos { get; set; }
        public short CantidadNinos { get; set; }
        public string CedulaCliente { get; set; }
        public short CodHabitacion { get; set; }
        public decimal PrecioHabitacion { get; set; }

        public virtual Cliente CedulaClienteNavigation { get; set; }
        public virtual Habitacion CodHabitacionNavigation { get; set; }
    }
}
