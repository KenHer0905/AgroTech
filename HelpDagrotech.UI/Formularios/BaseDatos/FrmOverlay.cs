using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HelpDagrotech.UI.Formularios.BaseDatos
{
    public partial class FrmOverlay : Form
    {
        // Constructor que recibe el formulario padre para ajustar la sombra
        public FrmOverlay(Form formularioPadre)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;

            // Mismo tamaño y posición del formulario principal
            Location = formularioPadre.PointToScreen(Point.Empty);
            Size = formularioPadre.ClientSize;

            BackColor = Color.FromArgb(30, 41, 59);
            Opacity = 0.45;

            ShowInTaskbar = false;
            TopMost = false;
        }

        private void FrmOverlay_Load(object sender, EventArgs e)
        {
            // Aquí puedes dejar esto vacío o eliminar este evento si no lo usas
        }
    }
}
