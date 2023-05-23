using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa
    {
        public static List<Mesa> listaMesas = new List<Mesa>();
        public static int cantidadMesas = 6;

        private EstadoMesa _estado;
        private int _cantidadClientes;
        private int _numeroDeMesa;
        private List<Producto>? _listaPedidos;
        

        public EstadoMesa Estado { get => _estado; set => _estado = value; }
        public int CantidadClientes { get => _cantidadClientes; set => _cantidadClientes = value; }
        internal List<Producto>? ListaPedidos { get => _listaPedidos; set => _listaPedidos = value; }
        public int NumeroDeMesa { get => _numeroDeMesa; set => _numeroDeMesa = value; }

        public Mesa(int numeroDeMesa)
        {
            NumeroDeMesa = numeroDeMesa;
            ListaPedidos = new List<Producto>();
        }
        public static void InicializarMesas()
        {
            for(int i = 0; i < cantidadMesas; i++)
            {
                Mesa mesa = new Mesa(i+1);
                mesa.Estado = EstadoMesa.libre;
                listaMesas.Add(mesa);
            }
        }
        public bool EstaLibre()
        {
            return Estado == EstadoMesa.libre;
        }

    }
}
