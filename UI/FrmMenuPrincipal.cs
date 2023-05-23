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
        Usuario usuarioLogueado;
        FrmLogin frmLogin;
        bool hayCambios = true;

        public FrmMenuPrincipal(Usuario usuario, FrmLogin frmLogin)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            this.frmLogin = frmLogin;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado is not null && usuarioLogueado.Rol == Roles.superUsuario)
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
            frmLogin.Show();
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarCambiosAntesDeSalir();
            Close();
            frmLogin.Close();
        }

        private void GuardarCambiosAntesDeSalir()
        {
            if (hayCambios)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios antes de salir?", "Guardar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Archivo.GuardarDatos(Usuario.pathRelativoUsuarios, Usuario.usuarios);
                }

            }
        }


        private void btnMesa2_Click(object sender, EventArgs e)
        {

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
            FrmProductos frmProductos = FrmProductos.InstanciarVentanaUnica();
            frmProductos.MdiParent = this;
            frmProductos.Show();
            frmProductos.BringToFront();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = FrmUsuarios.InstanciarVentanaUnica();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
            frmUsuarios.BringToFront();
        }

    }
}
