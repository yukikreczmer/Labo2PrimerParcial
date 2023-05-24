using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Entidades
{
    public class Producto : Parser
    {
        public static List<Parser> productos = new List<Parser>();
        public static string pathRelativoProductos = "productos.txt";
        private static int _idStatic = 0;

        private string? _nombre;
        private decimal _precio;
        private int _stock;
        private int _id;


        public string? Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int Id { get => _id; set => _id = value; }

        public Producto(string? nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Id = CrearId();
            Stock = stock;
        }
        public Producto(string? nombre, decimal precio, int id, int stock) : this(nombre, precio, stock)
        {
            Id = id;
        }
        private static int CrearId()
        {
            _idStatic++;
            return _idStatic;
        }

        public override string ParsearDatoAGuardar()
        {
            return $"{Nombre}-{Precio}-{Id}-{Stock}";
        }

        public static void CargarProductos()
        {
            List<string> listaProductosString = Archivo.LeerArchivo(pathRelativoProductos);
            ParsearProductos(listaProductosString, productos);
        }



        public static explicit operator Producto(string linea)
        {
            string[] cadenaDatos = linea.Split('-');
            string nombre = cadenaDatos[0];
            if (!int.TryParse(cadenaDatos[1], out int precio))
            {
                throw new Exception("Error al intentar cargar el precio del producto.");
            }
            if (!int.TryParse(cadenaDatos[2], out int id))
            {
                throw new Exception("Error al intentar cargar el id del producto.");
            }
            if (!int.TryParse(cadenaDatos[3], out int stock))
            {
                throw new Exception("Error al intentar cargar el stock del producto.");
            }

            Producto producto = new Producto(nombre, precio, id, stock);

            return producto;
        }
        public static List<Producto> VerListaComoProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            foreach (Producto item in productos)
            {
                listaProductos.Add(item);
            }
            return listaProductos;
        }
        public static Producto GetProductoByIdOrThrow(int id)
        {
            foreach (Producto item in productos)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new Exception("Producto no encontrado");
        }
        public bool HayStockSuficienteOrThrow(int cantidadPedida)
        {
            if (Stock < cantidadPedida)
            {
                throw new Exception($"No hay stock suficiente de {Nombre}");
            }

            return true;
        }
        public void AgregarProductoALista(Producto productoAAgregar, int cantidad, List<Producto> listaDeProductosDestino)
        {
            if (listaDeProductosDestino is null || productoAAgregar is null)
            {
                throw new Exception("lista de productos a agregar o producto seleccionado nulo");
            }
            if (cantidad < 1)
            {
                throw new Exception("La cantidad minima para agregar es 1");
            }

            if (productoAAgregar.HayStockSuficienteOrThrow(cantidad))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    listaDeProductosDestino.Add(productoAAgregar);
                }
                productoAAgregar.Stock -= cantidad;
            }
        }
        public static void PasarProductosDeUnaListaAOtra(List<Producto> origen, List<Producto> destino)
        {
            foreach (Producto producto in origen)
            {
                destino.Add(producto);
            }
        }

        public void EliminarProductoDeLista(Producto productoAEliminar, List<Producto> listaProductosAEliminar)
        {
            if (productoAEliminar is null || listaProductosAEliminar is null)
            {
                throw new Exception("lista de producto a eliminar o producto seleccionado nulo");
            }
            foreach (Producto producto in listaProductosAEliminar)
            {
                if (producto.Id == productoAEliminar.Id)
                {
                    listaProductosAEliminar.Remove(producto);
                    producto.Stock++;
                }
            }

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Nombre} \t {Precio}");

            return sb.ToString();
        }

        public static void AgregarProducto(string nombre, string precioIngresado, string stockIngresado)
        {
            decimal precio;
            int stock;
            if (Validadora.ValidarNombre(nombre) && Validadora.ValidarPrecio(precioIngresado, out precio) && int.TryParse(stockIngresado, out stock))
            {
                Producto productoAAgregar = new Producto(nombre, precio, stock);
                productos.Add(productoAAgregar);
            }
            else
            {
                throw new Exception("Error en los datos a ingresar");
            }

        }
        public void ModificarProducto(string nombre, string precioIngresado, string stockIngresado)
        {
            decimal precioAModificar;
            int stockAModificar;
            if (Validadora.ValidarNombre(nombre) && Validadora.ValidarPrecio(precioIngresado, out precioAModificar) && int.TryParse(stockIngresado, out stockAModificar))
            {                
                Nombre = nombre;
                Precio = precioAModificar;
                Stock = stockAModificar;                
            }
            else
            {
                throw new Exception("Error en los datos a ingresar");
            }
        }

        public static void BajarProducto(Producto productoABajar)
        {
            foreach(Producto item in productos)
            {
                if(item.Equals(productoABajar))
                {
                    productos.Remove(productoABajar);
                    break;
                }
            }
        }
    }
}