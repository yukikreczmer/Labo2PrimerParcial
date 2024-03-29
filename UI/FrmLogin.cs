using Entidades;
using Entidades.SQL;

namespace UI
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            Anchor = AnchorStyles.Right;
        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {            
            try
            {
                UsuarioDB usuarioDB = new UsuarioDB(ConnectionStrings.local.ToString());
                await usuarioDB.TraerListaParser();
                
                ProductoDB productoDB = new ProductoDB(ConnectionStrings.local.ToString());
                await productoDB.TraerListaParser();
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
                if(!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContrase�a.Text))
                {
                    usuarioIngresado = Usuario.LoguearUsuario(txtUsuario.Text, txtContrase�a.Text);
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
            txtContrase�a.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            lblErrorUsuario.Visible = false;
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "supermario";
            txtContrase�a.Text = "rampi123";
        }
    }
}