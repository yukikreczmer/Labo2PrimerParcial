using Entidades;
using Entidades.SQL;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            try
            {
                UsuarioDB usuarioDB = new UsuarioDB(ConnectionStrings.local.ToString());
                Usuario.usuarios = usuarioDB.TraerListaParser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}