using AccesoDatos;
using Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Logica : ILogica
    {
        private readonly IAccesoSQL _iaccesoSQL;

        public Logica(IAccesoSQL iaccesoSQL)
        {
            _iaccesoSQL = iaccesoSQL;
        }

        public bool AgregarCliente(Cliente P_Entidad)
        {
            return _iaccesoSQL.AgregarCliente(P_Entidad);
        }

        public bool AgregarHabitacion(Habitacion P_Entidad)
        {
            return _iaccesoSQL.AgregarHabitacion(P_Entidad);
        }

        public bool AgregarReserva(Reserva P_Entidad)
        {
            return _iaccesoSQL.AgregarReserva(P_Entidad);
        }

        public List<Cliente> ConsultarCliente(Cliente P_Entidad)
        {
            return _iaccesoSQL.ConsultarCliente(P_Entidad);
        }

        public List<Habitacion> ConsultarHabitacion(Habitacion P_Entidad)
        {
            return _iaccesoSQL.ConsultarHabitacion(P_Entidad);
        }

        public List<Reserva> ConsultarReserva(Reserva P_Entidad)
        {
            return _iaccesoSQL.ConsultarReserva(P_Entidad);
        }

        public bool EliminarCliente(Cliente P_Entidad)
        {
            return _iaccesoSQL.EliminarCliente(P_Entidad);
        }

        public bool EliminarHabitacion(Habitacion P_Entidad)
        {
            return _iaccesoSQL.EliminarHabitacion(P_Entidad);
        }

        public bool EliminarReserva(Reserva P_Entidad)
        {
            return _iaccesoSQL.EliminarReserva(P_Entidad);
        }

        public bool ModificarCliente(Cliente P_Entidad)
        {
            return _iaccesoSQL.ModificarCliente(P_Entidad);
        }

        public bool ModificarHabitacion(Habitacion P_Entidad)
        {
            return _iaccesoSQL.ModificarHabitacion(P_Entidad);
        }

        public bool ModificarReserva(Reserva P_Entidad)
        {
            return _iaccesoSQL.ModificarReserva(P_Entidad);
        }
    }
}
