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
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        public static FrmUsuarios InstanciarVentanaUnica()
        {
            if (_instancia is null)
            {
                _instancia = new FrmUsuarios();
            }
            return _instancia;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.VerListaComoUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.AgregarUsuario(txbApellido.Text, txbNombre.Text, txbDni.Text, txbNombreUsuario.Text, txbContrasenia.Text, txbContraseniaRepetida.Text, chbSuperUsuario.Checked);

            }catch (Exception ex)
            {
                lblMensajeError.Text = ex.Message;
                lblMensajeError.Visible = true;
            }
        }

        

    }
}
