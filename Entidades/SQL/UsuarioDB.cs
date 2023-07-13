using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class UsuarioDB : SQLConsultas, IManipulable<Parser>
    {
        public UsuarioDB(string connectionString) : base(connectionString)
        {
        }

        public async Task AgregarAsync(Usuario usuario)
        {
            string consulta = "INSERT INTO usuarios (apellido, nombre, dni, nombreUsuario, rol, contrasenia) VALUES (@apellido, @nombre, @dni, @nombreUsuario, @rol, @contrasenia)";
            
            using (var comando = await CrearComandoAsync(consulta))
            {
                comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@dni", usuario.Dni);
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@rol", usuario.Rol.ToString());
                comando.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                
                await EjecutarNonQueryAsync(comando);
            }
        }


        public async Task EliminarAsync(string nombreUsuario)
        {
            string consulta = "DELETE FROM usuarios where nombreUsuario = @nombreUsuario";
            using (var comando = await CrearComandoAsync(consulta))
            {
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                await EjecutarNonQueryAsync(comando);
            }

        }

        public async Task ModificarAsync(Usuario usuario)
        {            
            string consulta = "UPDATE usuarios SET apellido = @apellido, nombre = @nombre, dni = @dni, nombreUsuario = @nombreUsuario, rol = @rol, contrasenia = @contrasenia WHERE nombreUsuario = @nombreUsuario";
            using (var comando = await CrearComandoAsync(consulta))
            {
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@dni", usuario.Dni);
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@rol", usuario.Rol.ToString());
                comando.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                
                await EjecutarNonQueryAsync(comando);
            }
        }

        public async Task<List<Parser>> TraerListaParser()
        {
            string consulta = "SELECT * FROM usuarios;";
            using (var comando = await CrearComandoAsync(consulta))
            {
                using (var dataTable = await EjecutarConsultaAsync(comando))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string apellido;
                        string nombre;
                        string dni;
                        string nombreUsuario;
                        string contrasenia;

                        apellido = row["apellido"].ToString().Trim();
                        nombre = row["nombre"].ToString().Trim();
                        dni = row["dni"].ToString().Trim();
                        nombreUsuario = row["nombreUsuario"].ToString().Trim();
                        Enum.TryParse(row["rol"].ToString().Trim(), out Roles rol);
                        contrasenia = row["contrasenia"].ToString().Trim();
                        Usuario.AgregarUsuario(apellido, nombre, dni, nombreUsuario, contrasenia, contrasenia, rol.ToString() == "superUsuario");
                    }
                }
                return Usuario.usuarios;
            }
           
        }

    }
}
