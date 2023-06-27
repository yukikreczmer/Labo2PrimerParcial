using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace Entidades.SQL
{
    public class Conexion
    {
        //la idea es no hacerla estatica sino con objeto y poder reutilizarlo
        //quizas le podes pasar el string connection o el server y nombre de db y que no se maneje estatico y con 1 sola instancia, que en algun momento puede traer errores
        
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string _connectionString;

        static Conexion()
        {
            _connectionString = @"Server=.;Database=Parcial2Labo2;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;
            _command.CommandType = System.Data.CommandType.Text;            
        }

        public static void Leer()
        {
            try
            {
                _connection.Open();
                _command.CommandText = "SELECT * FROM usuarios";
                using (SqlDataReader dataReader = _command.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                         string apellido;
                         string nombre;
                         string dni;
                         string nombreUsuario;
                         string contrasenia;

                         apellido = dataReader.GetString(0).Trim();
                         nombre = dataReader.GetString(1).Trim();
                         dni = dataReader.GetString(2).Trim();
                         nombreUsuario = dataReader.GetString(3).Trim();
                         Enum.TryParse(dataReader.GetString(4).Trim(), out Roles rol);
                         contrasenia = dataReader.GetString(5).Trim();
                         Usuario.AgregarUsuario(apellido, nombre, dni, nombreUsuario, contrasenia, contrasenia, rol.ToString() == "superUsuario");

                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        public static int AgregarEnBDD (Parser datoAAgregar)
        {
            try
            {
                _connection.Open();
                _command.CommandText = $"INSERT INTO {datoAAgregar.ParsearDatoAGuardarDB()})";
                return _command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }





    }
}
