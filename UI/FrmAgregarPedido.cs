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
    public partial class FrmAgregarPedido : Form
    {                
        List<Producto> listaProductosDeLaMesa; //productos que ya tenia pedidos y a la que le puedo agregar productos
        List<Producto> listaProductosAAgregar; //productos que pide para agregar a la mesa
        public FrmAgregarPedido(List<Producto> productos)
        {
            listaProductosDeLaMesa = productos;
            listaProductosAAgregar = new List<Producto>();            
            InitializeComponent();
        }

        private void FrmAgregarPedido_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto productoAAgregar;
            int cantidad = (int)nmcCantidadAAgregar.Value;
            int posicion = dgvProductosGenerales.CurrentRow.Index;
            productoAAgregar =SeleccionarProductoDeDgv(posicion,dgvProductosGenerales);

            try
            {
                productoAAgregar.AgregarProductoALista(productoAAgregar, cantidad, listaProductosAAgregar);
                lblMensajeError.Visible = false;
            }catch(Exception ex)
            {
                lblMensajeError.Visible = true;
                lblMensajeError.Text = ex.Message;
            }                
            ActualizarDgv();            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto productoAEliminar;            
            int posicion = 0;
            productoAEliminar = SeleccionarProductoDeDgv(posicion,dgvProductosAAgregar);
            productoAEliminar.EliminarProductoDeLista(productoAEliminar, listaProductosAAgregar);
        }

        private Producto SeleccionarProductoDeDgv(int posicion, DataGridView dgvOrigenASeleccionar)
        {
            Producto productoSeleccionado;
            int idProducto;
            int.TryParse(dgvOrigenASeleccionar[3, posicion].Value.ToString(), out idProducto);
            productoSeleccionado = Producto.GetProductoByIdOrThrow(idProducto);
            return productoSeleccionado;
        }

        private void ActualizarDgv()
        {
            dgvProductosGenerales.DataSource = null;
            dgvProductosGenerales.DataSource = Producto.VerListaComoProductos();
            dgvProductosAAgregar.DataSource = null;
            dgvProductosAAgregar.DataSource = listaProductosAAgregar;
        }

        private void dgvProductosAAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvProductosAAgregar.CurrentRow.Index;
            MessageBox.Show(dgvProductosAAgregar[3, posicion].Value.ToString());
            btnEliminar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Producto.PasarProductosDeUnaListaAOtra(listaProductosAAgregar, listaProductosDeLaMesa);            
            DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> listaFiltradaProductos = new List<Producto>();
            foreach (Producto item in Producto.VerListaComoProductos())
            {
                if (item.Nombre!.ToLower().Contains(txbProductoABuscar.Text.ToLower()))
                {
                    listaFiltradaProductos.Add(item);
                }
            }
            dgvProductosGenerales.DataSource = null;
            dgvProductosGenerales.DataSource = listaFiltradaProductos;
        }
    }
}
