using System.Net;

namespace Entidades
{
    public class Producto : Parser
    {
        public static List<Parser> productos = new List<Parser>();
        public static string pathRelativoProductos = "productos.txt";
        private static int _idStatic = 0;

        private string? _nombre;
        private decimal _precio;
        private int _id;
        private int _stock;


        public string? Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public int Id { get => _id; set => _id = value; }
        public int Stock { get => _stock; set => _stock = value; }

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
            foreach(Producto item in productos)
            {
                listaProductos.Add(item);
            }
            return listaProductos;
        }
    }
}