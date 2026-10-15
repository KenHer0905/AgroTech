using HelpDagrotech.UI.Helpers;
using HelpDAgroTech.Bll.Common;
using HelpDAgroTech.Dal.Cpmmon;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HelpDagrotech.UI.Helpers.RedonderControlesHelper;

namespace HelpDagrotech.UI.Formularios.Seguridad
{
    public partial class FrmConfiguracio : Form
    {
        public FrmConfiguracio()
        {
            InitializeComponent();
        }
        private bool ValidarCampos()
        {
            erroIcon.Clear();
            bool valido = true;
            if (!ValidarHelper.Requerido(txtSer, erroIcon, "Debe ingresar el Servidor."))
                valido = false;
            if (!ValidarHelper.Requerido(txtBD, erroIcon, "Debe ingresar la base de datos."))
                valido = false;
            if (!ValidarHelper.Requerido(txtContr, erroIcon, "Debe ingresar la contraseña."))
                valido = false;
            if (!ValidarHelper.Requerido(txtUsuSQL, erroIcon, "Debe ingresar el Usuario."))
                valido = false;
            return valido;
        }


        private void FrmConfiguracio_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Iccancelr_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

      
        private void IcGuardar_Click(object sender, EventArgs e)
        {
            ConexioneEntity config = new()
            {
                Servidor = txtSer.Text.Trim(),
                BaseDatos = txtBD.Text.Trim(),
                Password = txtContr.Text.Trim(),
                UsuarioSql = txtUsuSQL.Text.Trim()
            };

            Configuraciondall Dall = new();
            bool resultado = Dall.Guardar(config);

            if (!resultado)
            {
                MessageBox.Show("No fue posible guardar la configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Configuración Guardada con exito", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void FrmConfiguracio_Shown(object sender, EventArgs e)
        {
            RedondearControles.RedondearControl(this, 25);
            RedondearControles.RedondearControl(panelConfi, 25);
            RedondearControles.RedondearControl(panelServid, 25);
            RedondearControles.RedondearControl(panelBDD, 25);
            RedondearControles.RedondearControl(panelUsuario, 25);
            RedondearControles.RedondearControl(panelcontra, 25);
        }

        private void txtSer_TextChanged(object sender, EventArgs e)
        {

        }

        private async void icprobarcon_Click_1(object sender, EventArgs e)
        {

            if (!ValidarCampos())
              
                return;
            ConexionBll conexionBll = new();
            bool ok = await conexionBll.ProbarConexion(
                txtSer.Text.Trim(),
                txtBD.Text.Trim(),
                txtUsuSQL.Text.Trim(),
                txtContr.Text);
            if (ok)
            {
                MessageBox.Show("Conexión Exitosa", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IcGuardar.Enabled = true;
                txtSer.Enabled = false;
                txtBD.Enabled = false;
                txtUsuSQL.Enabled = false;
                txtContr.Enabled = false;
            }

            else
            {
                MessageBox.Show("No fue posible hacer la conexión de la Base de Dato", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IcGuardar.Enabled = false;
            }

        }
    }
} 
