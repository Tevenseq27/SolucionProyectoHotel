using Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public interface IAccesoSQL
    {
        //CLIENTE
        bool AgregarCliente(Cliente P_Entidad);
        bool ModificarCliente(Cliente P_Entidad);
        bool EliminarCliente(Cliente P_Entidad);
        List<Cliente> ConsultarCliente(Cliente P_Entidad);

        //HABITACIÓN
        bool AgregarHabitacion(Habitacion P_Entidad);
        bool ModificarHabitacion(Habitacion P_Entidad);
        bool EliminarHabitacion(Habitacion P_Entidad);
        List<Habitacion> ConsultarHabitacion(Habitacion P_Entidad);

        //RESERVA
        bool AgregarReserva(Reserva P_Entidad);
        bool ModificarReserva(Reserva P_Entidad);
        bool EliminarReserva(Reserva P_Entidad);
        List<Reserva> ConsultarReserva(Reserva P_Entidad);
    }
}
