using HelpDagrotech.UI.Formularios;
using HelpDagrotech.UI.Formularios.Seguridad;
using HelpDAgroTech.Bll;
using HelpDAgroTech.Dal;
using HelpDAgroTech.Dal.Cpmmon;

namespace HelpDagrotech.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            Configuraciondall configuraciondall = new();
            // Si no existe la configuración, Solicitarla
            if (!configuraciondall.ExisteConfiguracion())
            {
                FrmConfiguracio frmConfiguracio = new FrmConfiguracio();
                DialogResult resultado = frmConfiguracio.ShowDialog();

                if (resultado != DialogResult.OK)
                    return;
            }
            //Leer Configuracion guardada
            var config = configuraciondall.Obtener();
            if(config is null)
            {
                MessageBox.Show("No fue posible cargar la configuracion de la conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            //Contruir la cadena de conexion
            Conexion.CadenaConexion =
                $"Server={config.Servidor};" +
                $"Database={config.BaseDatos};" +
                $"Password={config.Password};" +
                $"User Id={config.UsuarioSql};" +
                $"TrustServerCertificate=True;";

            try
            {
                SistemaBll sistemaBll = new SistemaBll(new SistemaDal());
                sistemaBll.CrearAdministradorInicialAsync()
                    .GetAwaiter()
                    .GetResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new FrmAgroT());
        }
    }
}