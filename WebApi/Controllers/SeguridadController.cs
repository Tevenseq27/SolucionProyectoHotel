using Entidades.Entities;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.Collections.Generic;
using System.Linq;

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
        public IEnumerable<Cliente> ConsultarCliente()
        {
            Cliente c = new Cliente();
            return _ilogica.ConsultarCliente(c).ToList();
        }

        [HttpPost]
        [Route(nameof(ModificarCliente))]
        public bool ModificarCliente()
        {
            Cliente c = new Cliente();
            return _ilogica.ModificarCliente(c);
        }

        [HttpPost]
        [Route(nameof(EliminarCliente))]
        public bool EliminarCliente()
        {
            Cliente c = new Cliente();
            return _ilogica.EliminarCliente(c);
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
        public IEnumerable<Habitacion> ConsultarHabitacion()
        {
            Habitacion h = new Habitacion();
            return _ilogica.ConsultarHabitacion(h).ToList();
        }

        [HttpPost]
        [Route(nameof(ModificarHabitacion))]
        public bool ModificarHabitacion()
        {
            Habitacion h = new Habitacion();
            return _ilogica.ModificarHabitacion(h);
        }

        [HttpPost]
        [Route(nameof(EliminarHabitacion))]
        public bool EliminarHabitacion()
        {
            Habitacion h = new Habitacion();
            return _ilogica.EliminarHabitacion(h);
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
        public IEnumerable<Reserva> ConsultarReserva()
        {
            Reserva r = new Reserva();
            return _ilogica.ConsultarReserva(r).ToList();
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
