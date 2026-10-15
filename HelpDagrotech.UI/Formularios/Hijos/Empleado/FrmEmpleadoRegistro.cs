using HelpDAgroTech.Bll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDagrotech.UI.Formularios.Hijos.Empleado
{
    public partial class FrmEmpleadoRegistro : Form
    {
        private readonly EmpleadoBll _empleadoBll = new();
        private readonly RolBll _rolBll = new();
        private readonly int? _empleadoId;

        // Constructor para NUEVO
        public FrmEmpleadoRegistro()
        {
            InitializeComponent();
            _empleadoId = null;
            LblTitulo.Text = "Nuevo Empleado";
        }

        // Constructor para EDITAR
        public FrmEmpleadoRegistro(int id) : this()
        {
            _empleadoId = id;
            LblTitulo.Text = "Editar Empleado";
        }

        private async void FrmEmpleadoRegistro_Load(object sender, EventArgs e)
        {
            await CargarRolesAsync();

            if (_empleadoId.HasValue)
            {
                // Cargar datos del empleado a editar en los TextBox
            }
        }

        private async Task CargarRolesAsync()
        {
            var roles = await _rolBll.MostrarRolesActivosAsync();
            CmbRol.DataSource = roles;
            CmbRol.DisplayMember = "Rol";
            CmbRol.ValueMember = "Id";
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Lógica de guardado...
                this.DialogResult = DialogResult.OK; // Cierra el modal y refresca el listado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
