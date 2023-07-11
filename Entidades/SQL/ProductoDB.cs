using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class ProductoDB : SQLConsultas, IManipulable<Parser>
    {
        public ProductoDB(string connectionString) : base(connectionString)
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

        public Parser Traer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Parser> TraerListaParser()
        {
            using (DataTable dataTable = EjecutarConsulta("SELECT * FROM productos"))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string nombre;
                    decimal precio;
                    int id;
                    int stock;
                    
                    nombre = row["nombre"].ToString().Trim();
                    decimal.TryParse(row["precio"].ToString().Trim(), out precio);
                    int.TryParse(row["id"].ToString().Trim(), out id);
                    int.TryParse(row["stock"].ToString().Trim(), out stock);

                    Producto producto = new(nombre, precio, id, stock);
                    Producto.productos.Add(producto);
                }
            }
            return Producto.productos;
        }
    }
}
