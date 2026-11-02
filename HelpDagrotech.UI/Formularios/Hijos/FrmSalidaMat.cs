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
using System.Windows.Controls;
using System.Windows.Forms;

namespace HelpDagrotech.UI.Formularios.Hijos
{
    public partial class FrmSalidaMat : Form
    {
        private EmpleadoBll _empleadoBLL = new EmpleadoBll(new EmpleadoDAL());
        private TerrenoBll _terrenobll = new TerrenoBll();
        private MaterialBll _materialbll = new MaterialBll();
        private SalidamaterialBll _salidabll = new SalidamaterialBll();
        public FrmSalidaMat()
        {
            InitializeComponent();
        }

        private void FrmSalidaMat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelsalidamat.Width - 1, panelsalidamat.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelsalidamat.Region = new Region(path);
            }
        }

        private async Task CargarMaterial()
        {
            try
            {
                var roles = await _materialbll.MostrarMaterialAsincrono();

                comboBox1.DataSource = roles;
                comboBox1.DisplayMember = "Nombre_material";
                comboBox1.ValueMember = "Id_material";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task CargarListadoMovimientosAsincrono()
        {
            try
            {
                List<EmpleadoEntity> lista = await
                    _empleadoBLL.MostrarAsincrono(txtbuscarSalidaMat.Text.Trim());
                dvgsalidamaterial.DataSource = null;
                dvgsalidamaterial.DataSource = lista;

                configurarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cragra los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task CargarEmpleadosAsync()
        {
            try
            {
                var roles = await _empleadoBLL.MostrarAsincrono();

                Cboxempleadosalida.DataSource = roles;
                Cboxempleadosalida.DisplayMember = "Nombre_empleado";
                Cboxempleadosalida.ValueMember = "Id_empleado";
                Cboxempleadosalida.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarTerrnos()
        {
            try
            {
                var roles = await _terrenobll.MostrarTerrenosAsincrono();

                Cboxterrenosalida.DataSource = roles;
                Cboxterrenosalida.DisplayMember = "Nombre_T";
                Cboxterrenosalida.ValueMember = "Id_Terreno";
                Cboxterrenosalida.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTipoMovimiento()
        {
            try
            {

                var tiposMovimiento = new[]
                {
            new { Texto = "Entrada", Valor = "Entrada" },
            new { Texto = "Salida", Valor = "Salida" }
        };

                CboxTipomO.DataSource = tiposMovimiento;
                CboxTipomO.DisplayMember = "Texto";
                CboxTipomO.ValueMember = "Valor";
                CboxTipomO.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los tipos de movimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configurarDataGrid()
        {
           
            if (dvgsalidamaterial.Columns.Count == 0)
                return;

         
            if (dvgsalidamaterial.Columns["Id_Movimiento"] != null)
                dvgsalidamaterial.Columns["Id_Movimiento"].Visible = false;

            if (dvgsalidamaterial.Columns["Id_empleado"] != null)
                dvgsalidamaterial.Columns["Id_empleado"].Visible = false;

            if (dvgsalidamaterial.Columns["Id_Terreno"] != null)
                dvgsalidamaterial.Columns["Id_Terreno"].Visible = false;

        
            if (dvgsalidamaterial.Columns["Fecha_Movimiento"] != null)
            {
                dvgsalidamaterial.Columns["Fecha_Movimiento"].HeaderText = "Fecha y Hora";
                dvgsalidamaterial.Columns["Fecha_Movimiento"].Width = 150;
            }

            if (dvgsalidamaterial.Columns["Nombre_empleado"] != null)
            {
                dvgsalidamaterial.Columns["Nombre_empleado"].HeaderText = "Empleado";
                dvgsalidamaterial.Columns["Nombre_empleado"].Width = 180;
            }

            if (dvgsalidamaterial.Columns["Nombre_T"] != null)
            {
                dvgsalidamaterial.Columns["Nombre_T"].HeaderText = "Terreno";
                dvgsalidamaterial.Columns["Nombre_T"].Width = 150;
            }

            if (dvgsalidamaterial.Columns["Tipo_Movimiento"] != null)
            {
                dvgsalidamaterial.Columns["Tipo_Movimiento"].HeaderText = "Tipo de Movimiento";
                dvgsalidamaterial.Columns["Tipo_Movimiento"].Width = 130;
            }

           
            if (dvgsalidamaterial.Columns["Nombre_empleado"] != null)
                dvgsalidamaterial.Columns["Nombre_empleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dvgsalidamaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dvgsalidamaterial.Rows[e.RowIndex];

            if (fila.Cells["Fecha_Movimiento"].Value != DBNull.Value)
            {
                txtFechaSalida.Value = Convert.ToDateTime(fila.Cells["Fecha_Movimiento"].Value);
            }

            if (fila.Cells["Id_empleado"].Value != null && fila.Cells["Id_empleado"].Value != DBNull.Value)
            {
                Cboxempleadosalida.SelectedValue = Convert.ToInt32(fila.Cells["Id_empleado"].Value);
            }

            
            if (fila.Cells["Id_Terreno"].Value != null && fila.Cells["Id_Terreno"].Value != DBNull.Value)
            {
                Cboxterrenosalida.SelectedValue = Convert.ToInt32(fila.Cells["Id_Terreno"].Value);
            }
            else
            {
                Cboxterrenosalida.SelectedIndex = -1;
            }

            
            CboxTipomO.Text = fila.Cells["Tipo_Movimiento"].Value?.ToString();

          
            txtFechaSalida.Enabled = false;
            Cboxempleadosalida.Enabled = false;
            Cboxterrenosalida.Enabled = false;
            CboxTipomO.Enabled = false;

           
            bttguardarsalida.Enabled = false;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panel6.Width - 1, panel6.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panel6.Region = new Region(path);
            }
        }

        private async void FrmSalidaMat_Load(object sender, EventArgs e)
        {
            await CargarEmpleadosAsync();
            await CargarTerrnos();
            await CargarMaterial();
            CargarTipoMovimiento();
            await CargarListadoMovimientosAsincrono();
        }
        private void Cboxterrenosalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void bttguardarsalida_Click(object sender, EventArgs e)
        {

            if (Cboxempleadosalida.SelectedValue == null || CboxTipomO.SelectedValue == null)
            {
                MessageBox.Show("Por favor complete los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SalidamaterialBll salidaBll = new SalidamaterialBll();


                int idEmpleado = Convert.ToInt32(Cboxempleadosalida.SelectedValue);
                int? idTerreno = Cboxterrenosalida.SelectedValue != null ? Convert.ToInt32(Cboxterrenosalida.SelectedValue) : (int?)null;
                string tipoMovimiento = CboxTipomO.SelectedValue.ToString();
                DateTime fechaMovimiento = txtFechaSalida.Value;
                SalidaMaterialEntity nuevoMovimiento = new SalidaMaterialEntity(
                    fechaMovimiento,
                    idEmpleado,
                    idTerreno,
                    tipoMovimiento
                );


                await _salidabll.RegistrarMovimientoAsync(nuevoMovimiento);

                MessageBox.Show("Movimiento registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                ///LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            await CargarListadoMovimientosAsincrono();
        }

        private  async void txtbuscarSalidaMat_TextChanged(object sender, EventArgs e)
        {
            await CargarListadoMovimientosAsincrono();
        }
    }
}
