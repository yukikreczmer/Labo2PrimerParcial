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

        public async Task AgregarAsync(Producto producto)
        {
            string consulta = "INSERT INTO productos (nombre, precio, id, stock) VALUES (@nombre, @precio, @id, @stock)";

            using (var comando = await CrearComandoAsync(consulta))
            {                
                comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.Parameters.AddWithValue("@id", producto.Id);
                comando.Parameters.AddWithValue("@stock", producto.Stock);

                await EjecutarNonQueryAsync(comando);
            }
        }

        public async Task EliminarAsync(int id)
        {
            string consulta = "DELETE FROM productos where id = @id";
            using (var comando = await CrearComandoAsync(consulta))
            {
                comando.Parameters.AddWithValue("@id", id);
                await EjecutarNonQueryAsync(comando);
            }
        }

        public async Task ModificarAsync(Producto producto)
        {
            string consulta = "UPDATE productos SET nombre = @nombre, precio = @precio, id = @id, stock = @stock WHERE id = @id";
           
            using (var comando = await CrearComandoAsync(consulta))
            {
                comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.Parameters.AddWithValue("@id", producto.Id);
                comando.Parameters.AddWithValue("@stock", producto.Stock);

                await EjecutarNonQueryAsync(comando);
            }
        }


        public async Task<List<Parser>> TraerListaParser()
        {
            string consulta = "SELECT * FROM productos;";
            using (var comando =  await CrearComandoAsync(consulta))
            {
                using (var dataTable = await EjecutarConsultaAsync(comando))
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
}
