using HelpDagrotech.UI.Helpers;
using HelpDAgroTech.Bll;
using HelpDAgroTech.Bll.Common;
using HelpDAgroTech.Dal;
using HelpDAgroTech.Dal.Common;
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

namespace HelpDagrotech.UI.Formularios
{
    public partial class FrmEmpelado : Form
    {
        private readonly EmpleadoBll _empleadoBLL;
        private readonly RolBll _rolBLL;
        private int? _idEmpleadoSeleccionado = null;

        public bool EsEdicion => _idEmpleadoSeleccionado.HasValue;

        public FrmEmpelado()
        {
            InitializeComponent();
            _empleadoBLL = new EmpleadoBll(new EmpleadoDAL());
            _rolBLL = new RolBll(new RolDal());
        }

        private async void FrmEmpelado_Load(object sender, EventArgs e)
        {

            await CargarRolesAsync();
            CargarEstados();
            await CargarListadoAsincrono();

        }

        private void AplicarRedondeos()
        {
            BtnGuardarEmpleado.FlatStyle = FlatStyle.Flat;
            BtnGuardarEmpleado.FlatAppearance.BorderSize = 0;

            btnEditarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEditarEmpleado.FlatAppearance.BorderSize = 0;

            bttnborraremple.FlatStyle = FlatStyle.Flat;
            bttnborraremple.FlatAppearance.BorderSize = 0;

            // 2. Aplicar bordes redondeados a los botones (Radio: 12)
            RedonderControlesHelper.RedondearControl(BtnGuardarEmpleado, 12);
            RedonderControlesHelper.RedondearControl(btnEditarEmpleado, 12);
            RedonderControlesHelper.RedondearControl(bttnborraremple, 12);
        }

        private async Task CargarRolesAsync()
        {
            try
            {
                var roles = await _rolBLL.MostrarRolesActivosAsync();

                conRol.DataSource = roles;
                conRol.DisplayMember = "Rol";
                conRol.ValueMember = "Id_Rol";
                conRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            var estados = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Activo"),
                new KeyValuePair<bool, string>(false, "Inactivo")
            };

            conEstado.DataSource = estados;
            conEstado.DisplayMember = "Value";
            conEstado.ValueMember = "Key";
            conEstado.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            IconError.Clear();
            bool valido = true;

            if (!ValidarHelper.Requerido(txtNombreEmple, IconError, "Debe ingresar el Nombre del Empleado."))
                valido = false;
            if (!ValidarHelper.Requerido(txttelefono, IconError, "Debe ingresar el número de teléfono."))
                valido = false;
            if (!ValidarHelper.Requerido(txtcedula, IconError, "Debe ingresar el número de cédula."))
                valido = false;
            if (!ValidarHelper.Requerido(txtcontrasena, IconError, "Debe ingresar la contraseña."))
                valido = false;


            if (conEstado.SelectedValue == null)
            {
                IconError.SetError(conEstado, "Debe seleccionar el estado.");
                valido = false;
            }


            if (conRol.SelectedValue == null)
            {
                IconError.SetError(conRol, "Debe ingresar el rol del Empleado.");
                valido = false;
            }

            return valido;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void paneEmpleado_Paint(object sender, PaintEventArgs e)
        {
        }

        private async Task CargarListadoAsincrono()
        {
            try
            {
                List<EmpleadoEntity> lista = await
                    _empleadoBLL.MostrarAsincrono(txtbuscaremplea.Text.Trim());
                dgvlistadoEmpleado.DataSource = null;
                dgvlistadoEmpleado.DataSource = lista;

                configurarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cragra los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void configurarDataGrid()
        {
            if (dgvlistadoEmpleado.Columns.Count == 0)
                return;

            if (dgvlistadoEmpleado.Columns["Id_empleado"] != null)
                dgvlistadoEmpleado.Columns["Id_empleado"].Visible = false;
            if (dgvlistadoEmpleado.Columns["Contrasena"] != null)
                dgvlistadoEmpleado.Columns["Contrasena"].Visible = false;
            if (dgvlistadoEmpleado.Columns["Id_Rol"] != null)
                dgvlistadoEmpleado.Columns["Id_Rol"].Visible = false;
            if (dgvlistadoEmpleado.Columns["Estado"] != null)
                dgvlistadoEmpleado.Columns["Estado"].Visible = false;

            if (dgvlistadoEmpleado.Columns["Nombre_empleado"] != null)
                dgvlistadoEmpleado.Columns["Nombre_empleado"].HeaderText = "Nombre del Empleado";
            if (dgvlistadoEmpleado.Columns["Telefono"] != null)
                dgvlistadoEmpleado.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvlistadoEmpleado.Columns["Estado texto"] != null)
                dgvlistadoEmpleado.Columns["Estado texto"].HeaderText = "Estado";
            if (dgvlistadoEmpleado.Columns["Cedula"] != null)
                dgvlistadoEmpleado.Columns["Cedula"].HeaderText = "Cédula";
            if (dgvlistadoEmpleado.Columns["Fecha_nacimiento"] != null)
                dgvlistadoEmpleado.Columns["Fecha_nacimiento"].HeaderText = "Fecha de nacimiento";
            // if (dgvlistadoEmpleado.Columns["Contrasena"] != null)
            //    dgvlistadoEmpleado.Columns["Contrasena"].HeaderText = "Contraseña";
            if (dgvlistadoEmpleado.Columns["Rol"] != null)
                dgvlistadoEmpleado.Columns["Rol"].HeaderText = "Rol";

            if (dgvlistadoEmpleado.Columns["Nombre_empleado"] != null)
                dgvlistadoEmpleado.Columns["Nombre_empleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async void BtnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                if (!EsEdicion)
                {
                    // Creamos el nuevo empleado usando el constructor de la entidad
                    EmpleadoEntity nuevo = new EmpleadoEntity(
                        txtNombreEmple.Text,
                        txttelefono.Text,
                        txtcedula.Text,
                        txtFechanacimiento.Value,
                        Convert.ToInt32(conRol.SelectedValue),
                        txtcontrasena.Text

                    );
                    btnEditarEmpleado.Enabled = false;

                    await _empleadoBLL.Agregar(nuevo, txtcontrasena.Text);

                    MessageBox.Show("Empleado agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            await CargarListadoAsincrono();
        }

        private void LimpiarFormulario()
        {
            _idEmpleadoSeleccionado = null;
            txtNombreEmple.Clear();
            txttelefono.Clear();
            txtcedula.Clear();
            txtcontrasena.Clear();
            txtFechanacimiento.Value = DateTime.Now;
            if (conRol.Items.Count > 0) conRol.SelectedIndex = -1;
            if (conEstado.Items.Count > 0) conEstado.SelectedIndex = 0;

            BtnGuardarEmpleado.Enabled = true;
            txtcedula.Enabled = true;
            txtcontrasena.Enabled = true;
            txtFechanacimiento.Enabled = true;
            txtNombreEmple.Focus();
        }

        private async void txtbuscaremplea_TextChanged(object sender, EventArgs e)
        {
            await CargarListadoAsincrono();

        }





        private async void btnEditarEmpleado_Click(object sender, EventArgs e)
        {

            try
            {
                if (_idEmpleadoSeleccionado == null || _idEmpleadoSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor, seleccione un empleado de la tabla para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreEmple.Text) || string.IsNullOrWhiteSpace(txttelefono.Text))
                {
                    MessageBox.Show("El nombre y el teléfono son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EmpleadoEntity empleadoModificado = new EmpleadoEntity(
                    txtNombreEmple.Text,
                    txttelefono.Text,
                    txtcedula.Text,
                    txtFechanacimiento.Value,
                    Convert.ToInt32(conRol.SelectedValue),
                    txtcontrasena.Text
                );


                empleadoModificado.AsignarId(_idEmpleadoSeleccionado.Value);


                await _empleadoBLL.Actualizar(empleadoModificado);

                MessageBox.Show("¡Empleado actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                LimpiarFormulario();
                await CargarListadoAsincrono();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvlistadoEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvlistadoEmpleado.Rows[e.RowIndex];
            _idEmpleadoSeleccionado = Convert.ToInt32(fila.Cells["Id_empleado"].Value);

            txtNombreEmple.Text = fila.Cells["Nombre_empleado"].Value?.ToString();
            txtcedula.Text = fila.Cells["Cedula"].Value?.ToString();
            txttelefono.Text = fila.Cells["Telefono"].Value?.ToString();
            txtcontrasena.Text = fila.Cells["Contrasena"].Value?.ToString();


            if (fila.Cells["Fecha_nacimiento"].Value != DBNull.Value) txtFechanacimiento.Value = Convert.ToDateTime(fila.Cells["Fecha_nacimiento"].Value);
            if (fila.Cells["Id_Rol"].Value != null && fila.Cells["Id_Rol"].Value != DBNull.Value)
                conRol.SelectedValue = Convert.ToInt32(fila.Cells["Id_Rol"].Value);

            txtcedula.Enabled = false;
            txtFechanacimiento.Enabled = false;
            txtcontrasena.Enabled = false;
            BtnGuardarEmpleado.Enabled = false;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEmpelado_Shown(object sender, EventArgs e)
        {
            AplicarRedondeos();
        }

        private void FrmEmpelado_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, paneEmpleado.Width - 1, paneEmpleado.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                paneEmpleado.Region = new Region(path);
            }
        }

        private void bttnborraremple_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
       
    }
    }
}

