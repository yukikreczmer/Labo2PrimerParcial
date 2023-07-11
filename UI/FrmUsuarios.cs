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
    public partial class FrmUsuarios : Form
    {        
        private static FrmUsuarios _instancia = null!;
        private FrmMenuPrincipal _frmMenuPrincipal = null!;
        public FrmUsuarios(FrmMenuPrincipal frmMenuPrincipal)
        {
            this._frmMenuPrincipal = frmMenuPrincipal;
            InitializeComponent();
        }

        public static FrmUsuarios InstanciarVentanaUnica(FrmMenuPrincipal frmMenuPrincipal)
        {
            if (_instancia is null)
            {
                _instancia = new FrmUsuarios(frmMenuPrincipal);
            }
            return _instancia;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
        }


        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuarioAAgregar;
            try
            {
                usuarioAAgregar = Usuario.AgregarUsuario(txbApellido.Text, txbNombre.Text, txbDni.Text, txbNombreUsuario.Text, txbContrasenia.Text, txbContraseniaRepetida.Text, chbSuperUsuario.Checked);
                _frmMenuPrincipal.logInformes.InformarEnLog(usuarioAAgregar, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnAgregarUsuario.Text);

                ActualizarCambioRealizado();
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = ex.Message;
                lblMensajeError.Visible = true;
            }
        }



        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            int dni;
            Roles rol;
            int posicion;            
            posicion = dgvUsuarios.CurrentRow.Index;
            List<Usuario> usuarios = Usuario.VerListaComoUsuarios();
            Usuario usuarioAModificar = usuarios[posicion];
            try
            {                
                Validadora.ValidarDatosUsuarioOrThrow(txbApellido.Text, txbNombre.Text, txbDni.Text, txbNombreUsuario.Text, txbContrasenia.Text, txbContraseniaRepetida.Text, chbSuperUsuario.Checked, out dni, out rol);
                if(usuarioAModificar != null)
                {                    
                    usuarioAModificar.ModificarUsuario(txbApellido.Text, txbNombre.Text, dni, txbNombreUsuario.Text, txbContrasenia.Text, rol);
                    _frmMenuPrincipal.logInformes.InformarEnLog(usuarioAModificar, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnModificarUsuario.Text);

                    ActualizarCambioRealizado();
                }
            }
            catch(Exception ex)
            {
                lblMensajeError.Text = ex.Message;
                lblMensajeError.Visible = true;
            }
        }

        private void btnBajarUsuario_Click(object sender, EventArgs e)
        {
            int posicion;
            posicion = dgvUsuarios.CurrentRow.Index;
            List<Usuario> usuarios = Usuario.VerListaComoUsuarios();
            Usuario usuarioABajar = usuarios[posicion];
            DialogResult result = MessageBox.Show($"¿Está seguro que desea dar de baja al usuario: {usuarioABajar.Nombre} {usuarioABajar.Apellido}?", "Dar de baja", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Usuario.BajarUsuario(usuarioABajar);
                _frmMenuPrincipal.logInformes.InformarEnLog(usuarioABajar, _frmMenuPrincipal.UsuarioLogueado.NombreUsuario, btnBajarUsuario.Text);
                ActualizarCambioRealizado();
            }
         }
        private void ActualizarDgv()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.VerListaComoUsuarios();
        }
        private void ActualizarCambioRealizado()
        {
            ActualizarDgv();
            lblMensajeError.Visible = false;
            _frmMenuPrincipal.hayCambios = true;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvUsuarios.CurrentRow.Index;
            txbApellido.Text = dgvUsuarios[0, posicion].Value.ToString();            
            txbNombre.Text = dgvUsuarios[1, posicion].Value.ToString();
            txbDni.Text = dgvUsuarios[2, posicion].Value.ToString();
            txbNombreUsuario.Text = dgvUsuarios[3, posicion].Value.ToString();
            if (dgvUsuarios[4,posicion].Value.ToString() == "superUsuario")
            {
                chbSuperUsuario.Checked = true;
            }
            else
            {
                chbSuperUsuario.Checked = false;
            }

        }
    }
}
