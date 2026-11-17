using System;
using System.Collections.Generic;
using System.Text;

namespace Control_de_autobuses
{
    public class CapaEntidades
    {
        public class Usuario
        {
            public int IdUsuario { get; set; }
            public string NombreUsuario { get; set; }
            public string Password { get; set; }
            public string Rol { get; set; }
        }

        public class Chofer
        {
            public int IdChofer { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Cedula { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Estado { get; set; }
        }

        public class Autobus
        {
            public int IdAutobus { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Placa { get; set; }
            public string Color { get; set; }
            public int Anio { get; set; }
            public string Estado { get; set; }
        }

        public class Ruta
        {
            public int IdRuta { get; set; }
            public string NombreRuta { get; set; }
            public string Descripcion { get; set; }
            public string Estado { get; set; }
        }

        public class Asignacion
        {
            public int IdAsignacion { get; set; }
            public int IdChofer { get; set; }
            public int IdAutobus { get; set; }
            public int IdRuta { get; set; }
            public DateTime Fecha { get; set; }
            public string HoraAsignacion { get; set; }
            public bool Activa { get; set; }

        }
    }
}

