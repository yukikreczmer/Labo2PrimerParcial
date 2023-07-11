using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa : IInformableLog
    {
        public static List<Mesa> listaMesas = new List<Mesa>();
        public static int cantidadMesas = 6;

        private EstadoMesa _estado;       
        private int _numeroDeMesa;
        private List<Producto>? _listaPedidos;        
        

        public EstadoMesa Estado { get => _estado; set => _estado = value; }        
        public List<Producto>? ListaPedidos { get => _listaPedidos; set => _listaPedidos = value; }
        public int NumeroDeMesa { get => _numeroDeMesa; set => _numeroDeMesa = value; }        

        public Mesa(int numeroDeMesa)
        {
            NumeroDeMesa = numeroDeMesa;
            ListaPedidos = new List<Producto>();
            Log.instanciaLog.HuboCambios += RegistrarCambio;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero de mesa: {NumeroDeMesa}");
            sb.AppendLine($"Pedidos:");
            sb.AppendLine("Producto: \t Precio:");
            foreach(Producto item in ListaPedidos!)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("");
            sb.AppendLine("TOTAL:");
            sb.AppendLine($"{CalcularMontoAPagar()}");


            return sb.ToString();
        }
        public decimal CalcularMontoAPagar()
        {
            decimal montoAPagar = 0;
            foreach(Producto item in ListaPedidos!)
            {
                montoAPagar += item.Precio;
            }
            return montoAPagar;
        }
        public void LimpiarMesa()
        {
            ListaPedidos!.Clear();            
            Estado = EstadoMesa.libre;
        }
        private string PrepararCambioAInformar(string usuarioModificador, string aclaracionABMoVenta)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(usuarioModificador);
            sb.AppendLine(aclaracionABMoVenta);
            sb.AppendLine(this.ToString());
            sb.AppendLine();

            return sb.ToString();
        }

        public void RegistrarCambio(IInformableLog informableSender, string usuarioModificador, string aclaracionABMoVenta)
        {
            if(informableSender == this)
            {
                string cambioAInformar = PrepararCambioAInformar(usuarioModificador, aclaracionABMoVenta);
                Archivo.GuardarDatos(IInformableLog.FileName, cambioAInformar);            
            }
        }



    }
}
