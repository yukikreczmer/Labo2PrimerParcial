using Entidades;
using Entidades.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmHome : Form
    {
        private static FrmHome _instancia = null!;
        private FrmMenuPrincipal _frmMenuPrincipal = null!;        

        public FrmHome(FrmMenuPrincipal frmMenuPrincipal)
        {
            InitializeComponent();
            _frmMenuPrincipal = frmMenuPrincipal;
        }
        public static FrmHome InstanciarVentanaUnica(FrmMenuPrincipal frmMenuPrincipal)
        {
            if(_instancia is null)
            {
                _instancia = new FrmHome(frmMenuPrincipal);
            }
            return _instancia;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Mesa.InicializarMesas();

            ActualizarColorBoton(btnMesa1, Mesa.listaMesas[0].Estado);
            ActualizarColorBoton(btnMesa2, Mesa.listaMesas[1].Estado);
            ActualizarColorBoton(btnMesa3, Mesa.listaMesas[2].Estado);
            ActualizarColorBoton(btnMesa4, Mesa.listaMesas[3].Estado);
            ActualizarColorBoton(btnMesa5, Mesa.listaMesas[4].Estado);
            ActualizarColorBoton(btnMesa6, Mesa.listaMesas[5].Estado);
            //Producto.CargarProductos();
            try
            {
                ProductoDB ProductoDB = new ProductoDB(ConnectionStrings.local.ToString());
                Producto.productos = ProductoDB.TraerListaParser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void ActualizarColorBoton(Button btn, EstadoMesa estado)
        {
            switch (estado)
            {
                case EstadoMesa.libre:
                    {
                        btn.BackColor = Color.Green;
                    }
                    break;
                case EstadoMesa.ocupada:
                    {
                        btn.BackColor = Color.Orange;
                    }
                    break;
                case EstadoMesa.reservada:
                    {
                        btn.BackColor = Color.Yellow;
                    }
                    break;
            }
        }
         
        private void btnMesa1_Click_1(object sender, EventArgs e)
        {
            Mesa mesa1 = Mesa.listaMesas[0];
            
            CambiarVisibilidadBotones(Mesa.listaMesas[0].NumeroDeMesa);                
            if (!mesa1.EstaLibre())
            {
                btnCobrarMesa1.Visible = !btnCobrarMesa1.Visible;                                                
            }            
            rtbListaPedidosMesa.Text = mesa1.ToString();

        }
        private void CambiarVisibilidadBotones(int numeroDeMesa)
        {
            switch(numeroDeMesa)
            {
                case 1:
                    btnAgregarPedidoMesa1.Visible = !btnAgregarPedidoMesa1.Visible;
                    break;
                case 2:
                    btnAgregarPedidoMesa2.Visible = !btnAgregarPedidoMesa2.Visible;
                    break;
                case 3:
                    btnAgregarPedidoMesa3.Visible = !btnAgregarPedidoMesa3.Visible;
                    break;
                case 4:
                    btnAgregarPedidoMesa4.Visible = !btnAgregarPedidoMesa4.Visible;
                    break;
                case 5:
                    btnAgregarPedidoMesa5.Visible = !btnAgregarPedidoMesa5.Visible;
                    break;
                case 6:
                    btnAgregarPedidoMesa6.Visible = !btnAgregarPedidoMesa6.Visible;
                    break;
            }

        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            Mesa mesa2 = Mesa.listaMesas[1];

            CambiarVisibilidadBotones(Mesa.listaMesas[1].NumeroDeMesa);
            if (!mesa2.EstaLibre())
            {
                btnCobrarMesa2.Visible = !btnCobrarMesa2.Visible;
            }
            rtbListaPedidosMesa.Text = mesa2.ToString();

        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            Mesa mesa3 = Mesa.listaMesas[2];

            CambiarVisibilidadBotones(Mesa.listaMesas[2].NumeroDeMesa);
            if (!mesa3.EstaLibre())
            {
                btnCobrarMesa3.Visible = !btnCobrarMesa3.Visible;
            }
            rtbListaPedidosMesa.Text = mesa3.ToString();

        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            Mesa mesa4 = Mesa.listaMesas[3];

            CambiarVisibilidadBotones(Mesa.listaMesas[3].NumeroDeMesa);
            if (!mesa4.EstaLibre())
            {
                btnCobrarMesa4.Visible = !btnCobrarMesa4.Visible;
            }
            rtbListaPedidosMesa.Text = mesa4.ToString();

        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            Mesa mesa5 = Mesa.listaMesas[4];

            CambiarVisibilidadBotones(Mesa.listaMesas[4].NumeroDeMesa);
            if (!mesa5.EstaLibre())
            {
                btnCobrarMesa5.Visible = !btnCobrarMesa5.Visible;
            }
            rtbListaPedidosMesa.Text = mesa5.ToString();

        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            Mesa mesa6 = Mesa.listaMesas[5];

            CambiarVisibilidadBotones(Mesa.listaMesas[5].NumeroDeMesa);
            if (!mesa6.EstaLibre())
            {
                btnCobrarMesa6.Visible = !btnCobrarMesa6.Visible;
            }
            rtbListaPedidosMesa.Text = mesa6.ToString();

        }

        private void btnAgregarPedidoMesa1_Click(object sender, EventArgs e)
        {
            Mesa mesaAtendida = Mesa.listaMesas[0];            
            FrmAgregarPedido frmAgregarPedido = new FrmAgregarPedido(mesaAtendida.ListaPedidos!);
            if( frmAgregarPedido.ShowDialog() == DialogResult.OK)
            {
                ActualizarPedidoMesa(mesaAtendida, btnMesa1);
            }            

        }


        private void btnAgregarPedidoMesa2_Click(object sender, EventArgs e)
        {
            Mesa mesaAtendida = Mesa.listaMesas[1];
            FrmAgregarPedido frmAgregarPedido = new FrmAgregarPedido(mesaAtendida.ListaPedidos!);
            if (frmAgregarPedido.ShowDialog() == DialogResult.OK)
            {
                ActualizarPedidoMesa(mesaAtendida, btnMesa2);
            }
        }

        private void btnAgregarPedidoMesa3_Click(object sender, EventArgs e)
        {
            Mesa mesaAtendida = Mesa.listaMesas[2];
            FrmAgregarPedido frmAgregarPedido = new FrmAgregarPedido(mesaAtendida.ListaPedidos!);
            if (frmAgregarPedido.ShowDialog() == DialogResult.OK)
            {
                ActualizarPedidoMesa(mesaAtendida, btnMesa3);
            }
        }

        private void btnAgregarPedidoMesa4_Click(object sender, EventArgs e)
        {
            Mesa mesaAtendida = Mesa.listaMesas[3];
            FrmAgregarPedido frmAgregarPedido = new FrmAgregarPedido(mesaAtendida.ListaPedidos!);
            if (frmAgregarPedido.ShowDialog() == DialogResult.OK)
            {
                ActualizarPedidoMesa(mesaAtendida, btnMesa4);
            }
        }

        private void btnAgregarPedidoMesa5_Click(object sender, EventArgs e)
        {
            Mesa mesaAtendida = Mesa.listaMesas[4];
            FrmAgregarPedido frmAgregarPedido = new FrmAgregarPedido(mesaAtendida.ListaPedidos!);
            if (frmAgregarPedido.ShowDialog() == DialogResult.OK)
            {
                ActualizarPedidoMesa(mesaAtendida, btnMesa5);
            }
        }

        private void btnAgregarPedidoMesa6_Click(object sender, EventArgs e)
        {
            Mesa mesaAtendida = Mesa.listaMesas[5];
            FrmAgregarPedido frmAgregarPedido = new FrmAgregarPedido(mesaAtendida.ListaPedidos!);
            if (frmAgregarPedido.ShowDialog() == DialogResult.OK)
            {
                ActualizarPedidoMesa(mesaAtendida, btnMesa6);
            }
        }
        private void ActualizarPedidoMesa(Mesa mesaAtendida, Button botonMesa)
        {
            rtbListaPedidosMesa.Text = mesaAtendida.ToString();
            mesaAtendida.Estado = EstadoMesa.ocupada;
            ActualizarColorBoton(botonMesa, EstadoMesa.ocupada);
        }

        private void btnCobrarMesa1_Click(object sender, EventArgs e)
        {
            Mesa mesa1 = Mesa.listaMesas[0];
            MessageBox.Show($"Se cobraron {mesa1.CalcularMontoAPagar()}");
            btnCobrarMesa1.Visible = false;

            _frmMenuPrincipal.logInformes.InformarEnLog(mesa1 , _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnCobrarMesa1.Text);

            mesa1.LimpiarMesa();
            ActualizarColorBoton(btnMesa1 , EstadoMesa.libre);
            rtbListaPedidosMesa.Text = mesa1.ToString();
        }

        private void btnCobrarMesa2_Click(object sender, EventArgs e)
        {
            Mesa mesa2 = Mesa.listaMesas[1];
            MessageBox.Show($"Se cobraron {mesa2.CalcularMontoAPagar()}");
            btnCobrarMesa2.Visible = false;
            
            _frmMenuPrincipal.logInformes.InformarEnLog(mesa2, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnCobrarMesa2.Text);
            
            mesa2.LimpiarMesa();
            ActualizarColorBoton(btnMesa2, EstadoMesa.libre);
            rtbListaPedidosMesa.Text = mesa2.ToString();
        }

        private void btnCobrarMesa3_Click(object sender, EventArgs e)
        {
            Mesa mesa3 = Mesa.listaMesas[2];
            MessageBox.Show($"Se cobraron {mesa3.CalcularMontoAPagar()}");
            btnCobrarMesa3.Visible = false;
            
            _frmMenuPrincipal.logInformes.InformarEnLog(mesa3, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnCobrarMesa3.Text);
            
            mesa3.LimpiarMesa();
            ActualizarColorBoton(btnMesa3, EstadoMesa.libre);
            rtbListaPedidosMesa.Text = mesa3.ToString();
        }

        private void btnCobrarMesa4_Click(object sender, EventArgs e)
        {
            Mesa mesa4 = Mesa.listaMesas[3];
            MessageBox.Show($"Se cobraron {mesa4.CalcularMontoAPagar()}");
            btnCobrarMesa4.Visible = false;
            
            _frmMenuPrincipal.logInformes.InformarEnLog(mesa4, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnCobrarMesa4.Text);
            
            mesa4.LimpiarMesa();
            ActualizarColorBoton(btnMesa4, EstadoMesa.libre);
            rtbListaPedidosMesa.Text = mesa4.ToString();
        }

        private void btnCobrarMesa5_Click(object sender, EventArgs e)
        {
            Mesa mesa5 = Mesa.listaMesas[4];
            MessageBox.Show($"Se cobraron {mesa5.CalcularMontoAPagar()}");
            btnCobrarMesa5.Visible = false;
            
            _frmMenuPrincipal.logInformes.InformarEnLog(mesa5, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnCobrarMesa5.Text);
            
            mesa5.LimpiarMesa();
            ActualizarColorBoton(btnMesa5, EstadoMesa.libre);
            rtbListaPedidosMesa.Text = mesa5.ToString();
        }

        private void btnCobrarMesa6_Click(object sender, EventArgs e)
        {
            Mesa mesa6 = Mesa.listaMesas[5];
            MessageBox.Show($"Se cobraron {mesa6.CalcularMontoAPagar()}");
            btnCobrarMesa6.Visible = false;
            
            _frmMenuPrincipal.logInformes.InformarEnLog(mesa6, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnCobrarMesa6.Text);
            
            mesa6.LimpiarMesa();
            ActualizarColorBoton(btnMesa6, EstadoMesa.libre);
            rtbListaPedidosMesa.Text = mesa6.ToString();
        }
    }
}
