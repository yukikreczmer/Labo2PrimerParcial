using Entidades;

namespace UI
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            Anchor = AnchorStyles.Right;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Usuario.CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioIngresado;
                if(!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
                {
                    usuarioIngresado = Usuario.LoguearUsuario(txtUsuario.Text, txtContraseña.Text);
                    FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuarioIngresado, this);
                    VaciarTextBoxes();
                    Hide();                    
                    frmMenuPrincipal.ShowDialog();          
                }
                else
                {
                    lblErrorUsuario.Text = "Por favor complete los campos";
                    lblErrorUsuario.Visible = true;
                }
            }
            catch(Exception ex)
            {
                lblErrorUsuario.Text = ex.Message;
                lblErrorUsuario.Visible = true;
            }
        }

        private void VaciarTextBoxes()
        {
            txtContraseña.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            lblErrorUsuario.Visible = false;
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "mauromauro";
            txtContraseña.Text = "asd123";
        }
    }
}