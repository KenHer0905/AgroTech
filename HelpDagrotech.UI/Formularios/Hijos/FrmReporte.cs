using HelpDagrotech.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDagrotech.UI.Formularios.Hijos
{
    public partial class FrmReporte : Form

    {


        protected int PaginaActual = 1;
        protected int TamPagina = 10;
        protected int TotalPaginas = 0;
        protected int TotalRegistro = 0;
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icnpinbuscarregistro_Click(object sender, EventArgs e)
        {

        }

        private void FrmReporte_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmReporte_Shown(object sender, EventArgs e)
        {

            RedonderControlesHelper.RedondearControl(panel3, 20);
            RedonderControlesHelper.RedondearControl(Panelpaginas, 20);


            
            RedonderControlesHelper.RedondearControl(iconButton5, 12);
          

            RedonderControlesHelper.RedondearControl(dgvListado, 15);
            RedonderControlesHelper.RedondearControl(iconPictureBox2, 15);
            RedonderControlesHelper.RedondearControl(panelbuscador, 15);
        }

        private void txtxbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
