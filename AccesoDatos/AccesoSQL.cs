using Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AccesoDatos
{
    public class AccesoSQL : IAccesoSQL
    {
        //AGREGAR CLIENTE
        public bool AgregarCliente(Cliente P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                contexto.Cliente.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //AGREGAR HABITACIÓN
        public bool AgregarHabitacion(Habitacion P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                contexto.Habitacion.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //AGREGAR RESERVA
        public bool AgregarReserva(Reserva P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                contexto.Reserva.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //CONSULTAR CLIENTE
        public List<Cliente> ConsultarCliente(Cliente P_Entidad)
        {
            HOTELBEJUCOSAContext contexto = null;
            List<Cliente> lista = new List<Cliente>();
            try
            {
                contexto = new HOTELBEJUCOSAContext();

                if (P_Entidad.CedulaCliente == null)
                {
                    var consulta = (from x in contexto.Cliente
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Cliente
                                    where x.CedulaCliente.Equals(P_Entidad.CedulaCliente)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        //CONSULTAR HABITACIÓN
        public List<Habitacion> ConsultarHabitacion(Habitacion P_Entidad)
        {
            HOTELBEJUCOSAContext contexto = null;
            List<Habitacion> lista = new List<Habitacion>();
            try
            {
                contexto = new HOTELBEJUCOSAContext();

                if (Convert.ToString(P_Entidad.CodHabitacion).Length == 0)
                {
                    var consulta = (from x in contexto.Habitacion
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Habitacion
                                    where x.CodHabitacion.Equals(P_Entidad.CodHabitacion)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        //CONSULTAR RESERVA
        public List<Reserva> ConsultarReserva(Reserva P_Entidad)
        {
            HOTELBEJUCOSAContext contexto = null;
            List<Reserva> lista = new List<Reserva>();
            try
            {
                contexto = new HOTELBEJUCOSAContext();

                if (Convert.ToString(P_Entidad.IdReserva).Length == 0)
                {
                    var consulta = (from x in contexto.Reserva
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Reserva
                                    where x.IdReserva.Equals(P_Entidad.IdReserva)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        //ELIMINAR CLIENTE
        public bool EliminarCliente(Cliente P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                var consulta = (from x in contexto.Cliente
                                where x.CedulaCliente.Equals(P_Entidad.CedulaCliente)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Cliente.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //ELIMINAR HABITACIÓN
        public bool EliminarHabitacion(Habitacion P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                var consulta = (from x in contexto.Habitacion
                                where x.CodHabitacion.Equals(P_Entidad.CodHabitacion)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Habitacion.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //ELIMINAR RESERVA
        public bool EliminarReserva(Reserva P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                var consulta = (from x in contexto.Reserva
                                where x.CodReserva.Equals(P_Entidad.CodReserva)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Reserva.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //MODIFICAR CLIENTE
        public bool ModificarCliente(Cliente P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                var consulta = (from x in contexto.Cliente
                                where x.CedulaCliente.Equals(P_Entidad.CedulaCliente)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.CedulaCliente = P_Entidad.CedulaCliente;
                    consulta.NombreCliente = P_Entidad.NombreCliente;
                    consulta.Apellido1Cliente = P_Entidad.Apellido1Cliente;
                    consulta.Apellido2Cliente = P_Entidad.Apellido2Cliente;
                    consulta.TelefonoCliente = P_Entidad.TelefonoCliente;
                    consulta.CorreoCliente = P_Entidad.CorreoCliente;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //MODIFICAR HABITACIÓN
        public bool ModificarHabitacion(Habitacion P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                var consulta = (from x in contexto.Habitacion
                                where x.CodHabitacion.Equals(P_Entidad.CodHabitacion)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.CodHabitacion = P_Entidad.CodHabitacion;
                    consulta.TipoHabitacion = P_Entidad.TipoHabitacion;
                    consulta.CapacidadHabitacion = P_Entidad.CapacidadHabitacion;
                    consulta.EstadoHabitacion = P_Entidad.EstadoHabitacion;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        //MODIFICAR RESERVA
        public bool ModificarReserva(Reserva P_Entidad)
        {
            bool resultado = false;
            HOTELBEJUCOSAContext contexto = null;

            try
            {
                contexto = new HOTELBEJUCOSAContext();
                var consulta = (from x in contexto.Reserva
                                where x.CodReserva.Equals(P_Entidad.CodReserva)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.CodReserva = P_Entidad.CodReserva;
                    consulta.FechaEntrada = P_Entidad.FechaEntrada;
                    consulta.FechaSalida = P_Entidad.FechaSalida;
                    consulta.CantidadAdultos = P_Entidad.CantidadAdultos;
                    consulta.CantidadNinos = P_Entidad.CantidadNinos;
                    consulta.CedulaCliente = P_Entidad.CedulaCliente;
                    consulta.CodHabitacion = P_Entidad.CodHabitacion;
                    consulta.PrecioHabitacion = P_Entidad.PrecioHabitacion;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
    }
}
