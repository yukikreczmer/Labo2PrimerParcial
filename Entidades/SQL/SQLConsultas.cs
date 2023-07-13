using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

        public async Task<DataTable> EjecutarConsultaAsync(SqlCommand command)
        {
            await AbrirAsync();
            
            SqlDataReader reader = await command.ExecuteReaderAsync();

            var dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();
            Cerrar();

            return dataTable;
        }

        public async Task<SqlCommand> CrearComandoAsync(string consulta)
        {
            await AbrirAsync();
            SqlCommand comando = new SqlCommand(consulta, Connection);
            return comando;
        }

        public async Task EjecutarNonQueryAsync(SqlCommand consulta)
        {
            await consulta.ExecuteNonQueryAsync();
        }

    }
}
