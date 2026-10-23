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
            NavegacionHelper.AbrirFormulario(new FrmEmpelado(), panelContenedo, ref formularioActivo, iconEmpleado );
        }

        private void FrmAgroT_Load(object sender, EventArgs e)
        {
          
        }
    
    }
}
 