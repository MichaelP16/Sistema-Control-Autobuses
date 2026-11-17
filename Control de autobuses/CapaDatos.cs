using System;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace Control_de_autobuses
{
    internal class CapaDatos
    {
        private readonly string connectionString = "Server=DESKTOP-FA0SAM7;Database=SistemaAutobuses;Integrated Security=True;Encrypt=False";

        public CapaEntidades.Usuario ValidarLogin(string user, string pass)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @user AND Password = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Accedemos a Usuario a través de la clase madre Entidades
                            return new CapaEntidades.Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
                                NombreUsuario = reader["NombreUsuario"].ToString(),
                                Password = reader["Password"].ToString(),
                                Rol = reader["Rol"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión a la base de datos: " + ex.Message);
            }
            return null;
        }
        // Método para listar choferes

        public List<CapaEntidades.Chofer> ListarChoferes()
        {
            List<CapaEntidades.Chofer> lista = new List<CapaEntidades.Chofer>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Choferes";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new CapaEntidades.Chofer
                        {
                            IdChofer = Convert.ToInt32(reader["ID_Chofer"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Cedula = reader["Cedula"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                            Estado = reader["Estado"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void GuardarChofer(CapaEntidades.Chofer chofer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Choferes (Nombre, Apellido, Cedula, FechaNacimiento) VALUES (@nom, @ape, @ced, @fec)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", chofer.Nombre);
                cmd.Parameters.AddWithValue("@ape", chofer.Apellido);
                cmd.Parameters.AddWithValue("@ced", chofer.Cedula);
                cmd.Parameters.AddWithValue("@fec", chofer.FechaNacimiento);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void EditarChofer(CapaEntidades.Chofer chofer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Choferes 
                         SET Nombre = @nom, 
                             Apellido = @ape, 
                             Cedula = @ced, 
                             FechaNacimiento = @fec 
                         WHERE ID_Chofer = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nom", chofer.Nombre);
                cmd.Parameters.AddWithValue("@ape", chofer.Apellido);
                cmd.Parameters.AddWithValue("@ced", chofer.Cedula);
                cmd.Parameters.AddWithValue("@fec", chofer.FechaNacimiento);
                cmd.Parameters.AddWithValue("@id", chofer.IdChofer);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarChoferPorNombre(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Choferes WHERE Nombre = @nom";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", nombre);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // metodos para listar rutas
        public List<CapaEntidades.Ruta> ListarRutas()
        {
            List<CapaEntidades.Ruta> lista = new List<CapaEntidades.Ruta>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rutas";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new CapaEntidades.Ruta
                        {
                            IdRuta = Convert.ToInt32(reader["ID_Ruta"]),
                            NombreRuta = reader["NombreRuta"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Estado = reader["Estado"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void GuardarRuta(CapaEntidades.Ruta ruta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Rutas (NombreRuta, Descripcion, Estado) VALUES (@nom, @des, @est)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", ruta.NombreRuta);
                cmd.Parameters.AddWithValue("@des", ruta.Descripcion);
                cmd.Parameters.AddWithValue("@est", ruta.Estado);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarRuta(CapaEntidades.Ruta ruta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Rutas SET NombreRuta=@nom, Descripcion=@des, Estado=@est WHERE ID_Ruta=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", ruta.NombreRuta);
                cmd.Parameters.AddWithValue("@des", ruta.Descripcion);
                cmd.Parameters.AddWithValue("@est", ruta.Estado);
                cmd.Parameters.AddWithValue("@id", ruta.IdRuta);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarRutaPorNombre(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Rutas WHERE NombreRuta = @nom";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", nombre);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //metodo para guardar asignaciones
        public void GuardarAsignacion(int idChofer, int idAutobus, int idRuta, DateTime fecha, TimeSpan hora)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Asignaciones (ID_Chofer, ID_Autobus, ID_Ruta, FechaAsignacion, HoraAsignacion) 
                         VALUES (@chofer, @bus, @ruta, @fecha, @hora)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@chofer", idChofer);
                cmd.Parameters.AddWithValue("@bus", idAutobus);
                cmd.Parameters.AddWithValue("@ruta", idRuta);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@hora", hora);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool ExisteAsignacion(int idChofer, int idAutobus, DateTime fecha, string hora)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                TimeSpan horaTs = TimeSpan.Parse(hora);

                string query = @"SELECT COUNT(*) FROM Asignaciones 
                         WHERE (ID_Chofer = @chofer OR ID_Autobus = @bus) 
                         AND CAST(FechaAsignacion AS DATE) = CAST(@fecha AS DATE) 
                         AND HoraAsignacion = @hora"; // Comparación directa es más rápida

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@chofer", idChofer);
                cmd.Parameters.AddWithValue("@bus", idAutobus);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@hora", horaTs); // Enviamos el TimeSpan

                conn.Open();
                int conteo = (int)cmd.ExecuteScalar();
                return conteo > 0;
            }
        }

        public void EditarAsignacion(int idAsignacion, int idChofer, int idAutobus, int idRuta, DateTime fecha)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Asignaciones 
                         SET ID_Chofer = @chofer, ID_Autobus = @bus, ID_Ruta = @ruta, FechaAsignacion = @fecha 
                         WHERE ID_Asignacion = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@chofer", idChofer);
                cmd.Parameters.AddWithValue("@bus", idAutobus);
                cmd.Parameters.AddWithValue("@ruta", idRuta);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@id", idAsignacion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAsignacion(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Asignaciones WHERE ID_Asignacion = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarAsignacionesCompletas()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                        A.ID_Asignacion, 
                        C.Nombre AS Chofer, 
                        B.Modelo AS Autobus, -- Cambié Placa por Modelo para cumplir tu requerimiento
                        R.NombreRuta AS Ruta, 
                        A.FechaAsignacion,
                        A.HoraAsignacion,
                        A.ID_Chofer, A.ID_Autobus, A.ID_Ruta
                     FROM Asignaciones A
                     INNER JOIN Choferes C ON A.ID_Chofer = C.ID_Chofer
                     INNER JOIN Autobuses B ON A.ID_Autobus = B.ID_Autobus
                     INNER JOIN Rutas R ON A.ID_Ruta = R.ID_Ruta";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(tabla);
            }
            return tabla;
        }

        // metodo para listar autobuses

        public List<CapaEntidades.Autobus> ListarAutobuses()
        {
            List<CapaEntidades.Autobus> lista = new List<CapaEntidades.Autobus>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Autobuses";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new CapaEntidades.Autobus {
                            IdAutobus = Convert.ToInt32(reader["ID_Autobus"]),
                            Marca = reader["Marca"].ToString(),
                            Modelo = reader["Modelo"].ToString(),
                            Placa = reader["Placa"].ToString(),
                            Color = reader["Color"].ToString(),
                            Anio = Convert.ToInt32(reader["Anio"]),
                            Estado = reader["Estado"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void GuardarAutobus(CapaEntidades.Autobus bus)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Autobuses (Marca, Modelo, Placa, Color, Anio, Estado) VALUES (@mar, @mod, @pla, @col, @ani, @est)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mar", bus.Marca);
                cmd.Parameters.AddWithValue("@mod", bus.Modelo);
                cmd.Parameters.AddWithValue("@pla", bus.Placa);
                cmd.Parameters.AddWithValue("@col", bus.Color);
                cmd.Parameters.AddWithValue("@ani", bus.Anio);
                cmd.Parameters.AddWithValue("@est", bus.Estado);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarAutobus(CapaEntidades.Autobus bus)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Autobuses SET Marca=@mar, Modelo=@mod, Placa=@pla, Color=@col, Anio=@ani, Estado=@est WHERE ID_Autobus=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mar", bus.Marca);
                cmd.Parameters.AddWithValue("@mod", bus.Modelo);
                cmd.Parameters.AddWithValue("@pla", bus.Placa);
                cmd.Parameters.AddWithValue("@col", bus.Color);
                cmd.Parameters.AddWithValue("@ani", bus.Anio);
                cmd.Parameters.AddWithValue("@est", bus.Estado);
                cmd.Parameters.AddWithValue("@id", bus.IdAutobus);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAutobus(string placa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Autobuses WHERE Placa = @pla";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pla", placa);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // metodos para guardar selecciones de usuarios
        public void GuardarSeleccionPersonal(int idUsuario, int idChofer, int idAutobus, int idRuta, DateTime fecha, TimeSpan hora)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO SeleccionesUsuario (ID_Usuario, ID_Chofer, ID_Autobus, ID_Ruta, FechaSeleccion, HoraSeleccion) 
                         VALUES (@usu, @cho, @bus, @rut, @fec, @hor)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usu", idUsuario);
                cmd.Parameters.AddWithValue("@cho", idChofer);
                cmd.Parameters.AddWithValue("@bus", idAutobus);
                cmd.Parameters.AddWithValue("@rut", idRuta);
                cmd.Parameters.AddWithValue("@fec", fecha);
                cmd.Parameters.AddWithValue("@hor", hora);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable ListarSeleccionesPorUsuario(int idUsuario)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT s.ID_Seleccion, c.Nombre as Chofer, b.Modelo as Autobus, 
                         r.NombreRuta as Ruta, s.FechaSeleccion as Fecha, s.HoraSeleccion as Hora
                         FROM SeleccionesUsuario s
                         INNER JOIN Choferes c ON s.ID_Chofer = c.ID_Chofer
                         INNER JOIN Autobuses b ON s.ID_Autobus = b.ID_Autobus
                         INNER JOIN Rutas r ON s.ID_Ruta = r.ID_Ruta
                         WHERE s.ID_Usuario = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }
        public bool ExisteAsignacion(int idC, int idA, DateTime fecha, TimeSpan hora)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT COUNT(*) FROM (
                -- Buscar en la tabla de Admins
                SELECT ID_Chofer, ID_Autobus FROM Asignaciones 
                WHERE FechaAsignacion = @fec AND HoraAsignacion = @hor
                UNION ALL
                -- Buscar en la tabla de Usuarios
                SELECT ID_Chofer, ID_Autobus FROM SeleccionesUsuario 
                WHERE FechaSeleccion = @fec AND HoraSeleccion = @hor
            ) AS TodasLasAsignaciones
            WHERE ID_Chofer = @idC OR ID_Autobus = @idA";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idC", idC);
                cmd.Parameters.AddWithValue("@idA", idA);
                cmd.Parameters.AddWithValue("@fec", fecha.Date); 
                cmd.Parameters.AddWithValue("@hor", hora);

                conn.Open();
                int conteo = Convert.ToInt32(cmd.ExecuteScalar());
                return conteo > 0;
            }
        }
        public void BorrarRegistro(int id, string rol)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string tabla = rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase)
                               ? "SeleccionesUsuario" : "Asignaciones";
                string columnaId = rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase)
                                   ? "ID_Seleccion" : "ID_Asignacion";

                string query = $"DELETE FROM {tabla} WHERE {columnaId} = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void EditarRegistro(int id, int idC, int idA, int idR, DateTime fecha, TimeSpan hora, string rol)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string tabla = rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase)
                               ? "SeleccionesUsuario" : "Asignaciones";
                string columnaId = rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase)
                                   ? "ID_Seleccion" : "ID_Asignacion";

                string fCol = rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase) ? "FechaSeleccion" : "FechaAsignacion";
                string hCol = rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase) ? "HoraSeleccion" : "HoraAsignacion";

                string query = $@"UPDATE {tabla} SET ID_Chofer=@cho, ID_Autobus=@bus, ID_Ruta=@rut, 
                         {fCol}=@fec, {hCol}=@hor WHERE {columnaId}=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cho", idC);
                cmd.Parameters.AddWithValue("@bus", idA);
                cmd.Parameters.AddWithValue("@rut", idR);
                cmd.Parameters.AddWithValue("@fec", fecha);
                cmd.Parameters.AddWithValue("@hor", hora);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
