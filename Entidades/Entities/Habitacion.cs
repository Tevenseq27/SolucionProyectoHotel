using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Habitacion
    {
        public Habitacion()
        {
            Reserva = new HashSet<Reserva>();
        }

        public short? CodHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        public short? CapacidadHabitacion { get; set; }
        public string EstadoHabitacion { get; set; }

        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}
