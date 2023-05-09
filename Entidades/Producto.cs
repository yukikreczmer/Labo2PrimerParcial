namespace Entidades
{
    internal class Producto
    {
        private string? _nombre;
        private decimal _precio;
        private int _id;


        public string? Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public int Id { get => _id; set => _id = value; }

        public Producto(string? nombre, decimal precio, int id)
        {
            Nombre = nombre;
            Precio = precio;
            Id = id;
        }

    }
}