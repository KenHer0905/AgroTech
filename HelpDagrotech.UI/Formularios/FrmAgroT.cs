using HelpDagrotech.UI.Formularios.BaseDatos;
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

namespace HelpDagrotech.UI.Formularios
{
    public partial class FrmAgroT : Form
    {
        //para conocer cual es el formulario que esta ativo 
        private Form? formularioActivo;
        private bool _cerrarsesion = false;


        public FrmAgroT()
        {
            InitializeComponent();
        }


        #region Sibedar
        private void IconButton1_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }
        #endregion

        #region Métodos
        public void CerrarSesion()
        {
            _cerrarsesion = true;
            DialogResult = DialogResult.Retry;
            Close();
        }
        #endregion

        private void FrmAgroT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cerrarsesion)
                return;

            DialogResult respuesta = MessageBox.Show("¿Seguro  que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }

        private void IconInicio_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivoIni(), panelContenedo, ref formularioActivo, iconInicio);
        }

        private void iconMiterreno_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmTerreno(), panelContenedo, ref formularioActivo, iconMiterreno);
        }

        private void iconCultivo_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivo(), panelContenedo, ref formularioActivo, iconCultivo);
        }

        private void iconMaterial_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmMaterial(), panelContenedo, ref formularioActivo, iconMaterial);
        }

        private void iconEmpleado_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmEmpelado(), panelContenedo, ref formularioActivo, iconEmpleado);
        }

        private void FrmAgroT_Load(object sender, EventArgs e)
        {


        }

        private void iconMiterreno_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmTerreno(), panelContenedo, ref formularioActivo, iconMiterreno);
        }

        private void iconEmpleado_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmEmpelado(), panelContenedo, ref formularioActivo, iconMiterreno);
        }

        private void iconCultivo_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivo(), panelContenedo, ref formularioActivo, iconMiterreno);
        }

        private void iconMaterial_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmMaterial(), panelContenedo, ref formularioActivo, iconMaterial);
        }

        private void iconInicio_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivoIni(), panelContenedo, ref formularioActivo, iconInicio);
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }

        private void FrmAgroT_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, AgroT.Width - 1, AgroT.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                AgroT.Region = new Region(path);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panel3.Width - 1, panel3.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panel3.Region = new Region(path);
            }
        }
    }
}

 