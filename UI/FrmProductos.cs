using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmProductos : Form
    {       
        private static FrmProductos _instancia = null!;
        private FrmMenuPrincipal _frmMenuPrincipal = null!;
        public FrmProductos(FrmMenuPrincipal frmMenuPrincipal)
        {
            this._frmMenuPrincipal = frmMenuPrincipal;
            InitializeComponent();            
        }
        public static FrmProductos InstanciarVentanaUnica(FrmMenuPrincipal frmMenuPrincipal)
        {
            if (_instancia is null)
            {
                _instancia = new FrmProductos(frmMenuPrincipal);
            }
            return _instancia;            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Producto.VerListaComoProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvProductos.CurrentRow.Index;
            txbNombre.Text = dgvProductos[0, posicion].Value.ToString();
            txbPrecio.Text = dgvProductos[1, posicion].Value.ToString();
            txbStock.Text = dgvProductos[2, posicion].Value.ToString();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto.AgregarProducto(txbNombre.Text,txbPrecio.Text,txbStock.Text);
                ActualizarCambioRealizado();                
            }catch(Exception ex)
            {
                lblMensajeError.Text = ex.Message;
                lblMensajeError.Visible = true;
            }
        }
        private void ActualizarCambioRealizado()
        {
            ActualizarDgv();
            lblMensajeError.Visible = false;
            _frmMenuPrincipal.hayCambios = true;
        }
        private void ActualizarDgv()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Producto.VerListaComoProductos();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {            
            int posicion = dgvProductos.CurrentRow.Index;
            List<Producto> productos = Producto.VerListaComoProductos();
            Producto productoAModificar = productos[posicion];
            try
            {
                productoAModificar.ModificarProducto(txbNombre.Text, txbPrecio.Text, txbStock.Text);
                ActualizarCambioRealizado();
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = ex.Message;
                lblMensajeError.Visible = true;
            }
        }

        private void btnBajarProducto_Click(object sender, EventArgs e)
        {
            int posicion = dgvProductos.CurrentRow.Index;
            List<Producto> productos = Producto.VerListaComoProductos();
            Producto productoABajar = productos[posicion];
            DialogResult result = MessageBox.Show($"¿Está seguro que desea dar de baja al producto: {productoABajar.Nombre}?", "Atención", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Producto.BajarProducto(productoABajar);
                ActualizarCambioRealizado();
            }
        }
    }
}
