using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Control_de_autobuses
{
    public class CapaNegocio
    {
        CapaDatos objDatos = new CapaDatos();

        public CapaEntidades.Usuario ValidarLogin(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                throw new Exception("El usuario y la contraseña no pueden estar vacíos.");
            }
            return objDatos.ValidarLogin(user, pass);
        }
        // Método para registrar un chofer 
        public void RegistrarChofer(CapaEntidades.Chofer chofer)
        {
            if (chofer.Cedula.Length < 11)
            {
                throw new Exception("La cédula debe tener al menos 11 dígitos.");
            }

            if (string.IsNullOrEmpty(chofer.Nombre) || string.IsNullOrEmpty(chofer.Apellido))
            {
                throw new Exception("El nombre y el apellido son obligatorios.");
            }

            objDatos.GuardarChofer(chofer);
        }

        public void Eliminar(string nombre)
        {
            objDatos.EliminarChoferPorNombre(nombre);
        }
        public void ActualizarChofer(CapaEntidades.Chofer chofer)
        {
            objDatos.EditarChofer(chofer);
        }
        public List<CapaEntidades.Chofer> ListadoChoferes()
        {
            return objDatos.ListarChoferes();
        }

        // Método para registrar un autobús
        public List<CapaEntidades.Autobus> ListadoAutobuses() => objDatos.ListarAutobuses();

        public void RegistrarAutobus(CapaEntidades.Autobus bus) => objDatos.GuardarAutobus(bus);

        public void ActualizarAutobus(CapaEntidades.Autobus bus) => objDatos.EditarAutobus(bus);

        public void EliminarBus(string placa) => objDatos.EliminarAutobus(placa);

        // Método para registrar una ruta
        public List<CapaEntidades.Ruta> ListadoRutas() => objDatos.ListarRutas();

        public void RegistrarRuta(CapaEntidades.Ruta ruta) => objDatos.GuardarRuta(ruta);

        public void ActualizarRuta(CapaEntidades.Ruta ruta) => objDatos.EditarRuta(ruta);

        public void EliminarRuta(string nombre) => objDatos.EliminarRutaPorNombre(nombre);

        
        //Método para listar asignaciones
        public void ActualizarAsignacion(int idAsig, int idC, int idA, int idR, DateTime fecha)
        {
            objDatos.EditarAsignacion(idAsig, idC, idA, idR, fecha);
        }

        public bool ValidarDisponibilidad(int idC, int idA, DateTime fecha, string hora)
        {
            return objDatos.ExisteAsignacion(idC, idA, fecha, hora);
        }

        public void BorrarAsignacion(int id)
        {
            objDatos.EliminarAsignacion(id);
        }
        public DataTable ListadoAsignaciones()
        {
            return objDatos.ListarAsignacionesCompletas();
        }

        public void RegistrarAsignacion(int idC, int idA, int idR, DateTime fecha, string hora)
        {
            objDatos.GuardarAsignacion(idC, idA, idR, fecha, TimeSpan.Parse(hora));
        }

        public static class SesionActual
        {
            public static CapaEntidades.Usuario UsuarioLogueado { get; set; }
        }
        public List<CapaEntidades.Chofer> ListarChoferes()
        {
            return objDatos.ListarChoferes();
        }

        public List<CapaEntidades.Autobus> ListarAutobuses()
        {
            return objDatos.ListarAutobuses();
        }

        public List<CapaEntidades.Ruta> ListarRutas()
        {
            return objDatos.ListarRutas();
        }
        public void GuardarSeleccionPersonal(int idUsuario, int idChofer, int idAutobus, int idRuta, DateTime fecha, string hora)
        {
            try
            {
                if (idUsuario <= 0)
                    throw new Exception("Sesión de usuario no válida.");

                TimeSpan horaTs = TimeSpan.Parse(hora);

                objDatos.GuardarSeleccionPersonal(idUsuario, idChofer, idAutobus, idRuta, fecha, horaTs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Negocio (Selección Personal): " + ex.Message);
            }
        }
        public void GuardarAsignacion(int idChofer, int idAutobus, int idRuta, DateTime fecha, string hora)
        {
            try
            {
                TimeSpan horaTs = TimeSpan.Parse(hora);

                 objDatos.GuardarAsignacion(idChofer, idAutobus, idRuta, fecha, horaTs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Negocio (Asignación General): " + ex.Message);
            }
        }
        // Método para obtener y modificar los datos del rol del usuario
        public DataTable ObtenerDatosGrid()
        {
            var usuario = SesionActual.UsuarioLogueado;

            if (usuario.Rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase))
            {
                return objDatos.ListarSeleccionesPorUsuario(usuario.IdUsuario);
            }
            else
            {
                return objDatos.ListarAsignacionesCompletas();
            }
        }
        public bool ValidarDisponibilidadTransporte(int idC, int idA, DateTime fecha, string hora)
        {
            try
            {
                TimeSpan horaTs = TimeSpan.Parse(hora);
                return objDatos.ExisteAsignacion(idC, idA, fecha, horaTs);
            }
            catch
            {
                return false;
            }
        }
        public void Borrar(int id)
        {
            string rol = SesionActual.UsuarioLogueado.Rol;
            objDatos.BorrarRegistro(id, rol);
        }

        public void Editar(int id, int idC, int idA, int idR, DateTime fecha, string hora)
        {
            string rol = SesionActual.UsuarioLogueado.Rol;
            TimeSpan horaTs = TimeSpan.Parse(hora);
            objDatos.EditarRegistro(id, idC, idA, idR, fecha, horaTs, rol);
        }
    }
}
