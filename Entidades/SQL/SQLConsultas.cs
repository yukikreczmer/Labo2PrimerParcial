using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class SQLConsultas : SQLConexion
    {
        public SQLConsultas(string connectionString) : base(connectionString)
        {
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            Abrir();
            
            SqlCommand command = new SqlCommand(consulta, Connection);
            SqlDataReader reader = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            Cerrar();

            return dataTable;
        }
        //execute non query nos trae la cantidad de filas afectadas. Usar para abm

    }
}
