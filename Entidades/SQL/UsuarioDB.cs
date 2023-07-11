using System;
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

        public int Agregar(Parser objeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Parser objeto)
        {
            throw new NotImplementedException();
        }

        public List<Parser> TraerListaParser()
        {
            using (DataTable dataTable = EjecutarConsulta("SELECT * FROM usuarios"))
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

        public Parser Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
