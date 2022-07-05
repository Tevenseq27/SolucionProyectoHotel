using Entidades.Entities;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/Seguridad")]
    [ApiController]
    public class SeguridadController : Controller
    {

        private readonly ILogica _ilogica;

        //Constructor
        public SeguridadController(ILogica ilogica)
        {
            _ilogica = ilogica;
        }

        public IActionResult Index()
        {
            return View();
        }

        //-----CLIENTE-----
        #region CLIENTE
        [HttpPost]
        [Route(nameof(AgregarCliente))]
        public bool AgregarCliente(Cliente P_Entidad)
        {
            return _ilogica.AgregarCliente(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarCliente))]
        public IEnumerable<Cliente> ConsultarCliente(Cliente P_Entidad)
        {
            return _ilogica.ConsultarCliente(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarCliente))]
        public bool ModificarCliente(Cliente Entidad)
        {
            return _ilogica.ModificarCliente(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarCliente))]
        public bool EliminarCliente(Cliente Entidad)
        {
            return _ilogica.EliminarCliente(Entidad);
        }
        #endregion

        //-----HABITACIÓN-----
        #region HABITACIÓN
        [HttpPost]
        [Route(nameof(AgregarHabitacion))]
        public bool AgregarHabitacion(Habitacion P_Entidad)
        {
            return _ilogica.AgregarHabitacion(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarHabitacion))]
        public IEnumerable<Habitacion> ConsultarHabitacion(Habitacion P_Entidad)
        {
            return _ilogica.ConsultarHabitacion(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarHabitacion))]
        public bool ModificarHabitacion(Habitacion Entidad)
        {
            return _ilogica.ModificarHabitacion(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarHabitacion))]
        public bool EliminarHabitacion(Habitacion Entidad)
        {
            return _ilogica.EliminarHabitacion(Entidad);
        }
        #endregion

        //-----RESERVA-----
        #region RESERVA
        [HttpPost]
        [Route(nameof(AgregarReserva))]
        public bool AgregarReserva(Reserva P_Entidad)
        {
            return _ilogica.AgregarReserva(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarReserva))]
        public IEnumerable<Reserva> ConsultarReserva(Reserva P_Entidad)
        {
            return _ilogica.ConsultarReserva(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarReserva))]
        public bool ModificarReserva(Reserva Entidad)
        {
            return _ilogica.ModificarReserva(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarReserva))]
        public bool EliminarReserva(Reserva Entidad)
        {
            return _ilogica.EliminarReserva(Entidad);
        }
        #endregion

    }
}
