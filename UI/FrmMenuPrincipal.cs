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
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario _usuarioLogueado;
        private FrmLogin _frmLogin;
        public bool hayCambios = false;

        public FrmMenuPrincipal(Usuario usuario, FrmLogin frmLogin)
        {
            InitializeComponent();
            this._usuarioLogueado = usuario;
            this._frmLogin = frmLogin;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (_usuarioLogueado is not null && _usuarioLogueado.Rol == Roles.superUsuario)
            {
                btnUsuarios.Visible = true;
            }
            FrmHome frmHome = FrmHome.InstanciarVentanaUnica();
            frmHome.MdiParent = this;
            frmHome.Show();
            frmHome.BringToFront();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarCambiosAntesDeSalir();
            _frmLogin.Show();
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarCambiosAntesDeSalir();
            Close();
            _frmLogin.Close();
        }

        private void GuardarCambiosAntesDeSalir()
        {
            if (hayCambios)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios antes de salir?", "Guardar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Archivo.GuardarDatos(Usuario.pathRelativoUsuarios, Usuario.usuarios);
                    Archivo.GuardarDatos(Producto.pathRelativoProductos, Producto.productos);
                }

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = FrmHome.InstanciarVentanaUnica();
            frmHome.MdiParent = this;
            frmHome.Show();
            frmHome.BringToFront();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = FrmProductos.InstanciarVentanaUnica(this);
            frmProductos.MdiParent = this;
            frmProductos.Show();
            frmProductos.BringToFront();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = FrmUsuarios.InstanciarVentanaUnica(this);
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
            frmUsuarios.BringToFront();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hayCambios = false;
            Archivo.GuardarDatos(Usuario.pathRelativoUsuarios, Usuario.usuarios);
            Archivo.GuardarDatos(Producto.pathRelativoProductos, Producto.productos);
        }
    }
}
