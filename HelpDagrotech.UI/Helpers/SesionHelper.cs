using HelpDagrotech.UI.Formularios;
using HelpDagrotech.UI.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDagrotech.UI.Helpers
{
    public class SesionHelper
    {
        public static void CargarDatosSesion(ToolStripStatusLabel lblUsuario, ToolStripStatusLabel lblRol)
        {
            lblUsuario.Text = $"Bienvenido, {UsuarioSesion.Nombre_empleado}";
            lblRol.Text = $"Rol: {UsuarioSesion.Rol}";
        }

        /// <summary>
        /// Cerrar la sesión del usuario.
        /// </summary>
        public static bool CerrarSesion(Form formularioActual)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return false;

            if (formularioActual is FrmAgroT principal)
                principal.CerrarSesion();
          /*  else if (formularioActual is FrmPanelAg panel)
                panel.CerrarSesion();*/
            else
                formularioActual.Close();

            return true;
        }
    }
}
