using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmHome : Form
    {
        private static FrmHome _instancia = null!;

        public FrmHome()
        {
            InitializeComponent();
        }
        public static FrmHome InstanciarVentanaUnica()
        {
            if(_instancia is null)
            {
                _instancia = new FrmHome();
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
            Producto.CargarProductos();
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
            if (Mesa.listaMesas[0].EstaLibre())
            {
                //ocupar, mostrar y agregar productos a la lista


                ActualizarColorBoton(btnMesa1, EstadoMesa.ocupada);
            }
            else
            {
                //mostrar info de la mesa en datagrid o algo asi                
            }
        }
    }
}
