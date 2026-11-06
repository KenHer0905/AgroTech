using HelpDAgroTech.Bll;
using HelpDAgroTech.Bll.Common;
using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace HelpDagrotech.UI.Formularios
{
    public partial class FrmMaterial : Form
    {
        private readonly MaterialBll _materialBll = new MaterialBll();
        private readonly object? listaCategorias;
        private string rutaImagenSeleccionada;
        private int? _idMateSeleccionado = null;

        public bool EsEdicion => _idMateSeleccionado.HasValue;

        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void LimpiarFormulario()
        {
            txtmaterial.Clear();
            txtstock.Clear();
            txtdescrip.Clear();
            txtminimost.Clear();
            txtxprecio.Clear();
            txtCategoriamate.SelectedIndex = -1;
            txtunidadmedida.SelectedIndex = -1;
            inpixmas.Image = null;
            rutaImagenSeleccionada = string.Empty;
        }

        private async void FrmMaterial_Load(object sender, EventArgs e)
        {
            CargarCategoriasYUnidades();
            await MostrarMaterialAsincrono();
        }

        private async Task MostrarMaterialAsincrono()
        {
            try
            {
                List<MaterialEntity> lista = await
                    _materialBll.MostrarMaterialAsincrono(txtbuscarMaterial.Text.Trim());
                dgvmateril.DataSource = null;
                dgvmateril.DataSource = lista;

                configurarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cragra los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void configurarDataGrid()
        {
            if (dgvmateril.Columns.Count == 0)
                return;


            //if (dgvmateril.Columns["Id"] != null)
            // dgvmateril.Columns["Id"].Visible = false;
            if (dgvmateril.Columns["Id_Material"] != null)
                dgvmateril.Columns["Id_Material"].Visible = false;
            if (dgvmateril.Columns["Id_Categoria"] != null)
                dgvmateril.Columns["Id_Categoria"].Visible = false;

            if (dgvmateril.Columns["Nombre_material"] != null)
                dgvmateril.Columns["Nombre_material"].HeaderText = "Material";
            if (dgvmateril.Columns["Nombre_categoria"] != null)
                dgvmateril.Columns["Nombre_categoria"].HeaderText = "Categoria";
            if (dgvmateril.Columns["Unidad_material"] != null)
                dgvmateril.Columns["Unidad_material"].HeaderText = "Unidad de medida";
            if (dgvmateril.Columns["Stock"] != null)
                dgvmateril.Columns["Stock"].HeaderText = "Stock";
            if (dgvmateril.Columns["Stock_minimo"] != null)
                dgvmateril.Columns["Stock_minimo"].HeaderText = "Stock minimo";
            if (dgvmateril.Columns["Precio"] != null)
                dgvmateril.Columns["Precio"].HeaderText = "Precio";

            if (dgvmateril.Columns["Nombre_material"] != null)
                dgvmateril.Columns["Nombre_material"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }



        private void CargarCategoriasYUnidades()
        {

            try
            {
                // 1. Crear la lista de categorías de forma compatible para el ComboBox
              var categorias = new Dictionary<int, string>
                {
                    { 1, "Fertilizantes" },
                    { 2, "Semillas" },
                    { 3, "Agroquímicos" },
                    { 4, "Herramientas" }
                }.ToList(); // .ToList() permite que Windows Forms lea perfectamente las propiedades Key y Value

                txtCategoriamate.DataSource = categorias;
                txtCategoriamate.DisplayMember = "Value";
                txtCategoriamate.ValueMember = "Key";
                txtCategoriamate.SelectedIndex = -1;

                // 2. Cargar las unidades de medida (una sola vez)
                txtunidadmedida.Items.Clear();
                txtunidadmedida.Items.Add("Libras (l)");
                txtunidadmedida.Items.Add("Litros (L)");
                txtunidadmedida.Items.Add("Quintal");
                txtunidadmedida.Items.Add("Unidad");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías y unidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        




        private void iconcancelma_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void inpixmas_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = openFile.FileName;
                    inpixmas.Image = Image.FromFile(rutaImagenSeleccionada);
                    inpixmas.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panel1.Region = new Region(path);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dgvmaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void iconeditar_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }


        private async void txtbuscarMaterial_TextChanged(object sender, EventArgs e)
        {
            await MostrarMaterialAsincrono();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void IconGuardarm_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmaterial.Text) ||
                string.IsNullOrWhiteSpace(txtminimost.Text) ||
                string.IsNullOrWhiteSpace(txtxprecio.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MaterialBll materialBll = new MaterialBll();

                int idCategoriaSeleccionada = txtCategoriamate.SelectedValue != null ? Convert.ToInt32(txtCategoriamate.SelectedValue) : 1;

                await materialBll.InsertarMaterialAsync(
                    txtmaterial.Text,
                    idCategoriaSeleccionada,
                    txtunidadmedida.Text,
                    Convert.ToDecimal(txtstock.Text),
                    Convert.ToDecimal(txtminimost.Text),
                    Convert.ToDecimal(txtxprecio.Text)
                );

                await MostrarMaterialAsincrono();
                // para mirarlo en el data griew
                //dgvmaterial.Rows.Add(txtmaterial.Text, txtCategoriamate.Text, txtdescrip.Text, txtstock.Text, txtminimost.Text, txtxprecio.Text, txtunidadmedida.Text);

                MessageBox.Show("Material registrado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error original de SQL: " + ex.InnerException?.Message ?? ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvmateril_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void txtbuscarMaterial_TextChanged_2(object sender, EventArgs e)
        {
            await MostrarMaterialAsincrono();
        }
        private async void FrmMaterial_Load_2(object sender, EventArgs e)
        {
            CargarCategoriasYUnidades();
            await MostrarMaterialAsincrono();
        }

        private void dgvmateril_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvmateril.Rows[e.RowIndex];

            if (fila.Cells["Id_Material"].Value != null)
            {
                _idMateSeleccionado = Convert.ToInt32(fila.Cells["Id_Material"].Value);
            }

            txtmaterial.Text = fila.Cells["Nombre_material"].Value?.ToString();
            txtunidadmedida.SelectedValue = fila.Cells["Unidad_material"].Value?.ToString();
            txtstock.Text = fila.Cells["Stock"].Value?.ToString();
            txtminimost.Text = fila.Cells["Stock_minimo"].Value?.ToString();
            txtxprecio.Text = fila.Cells["Precio"].Value?.ToString();

            if (fila.Cells["Id_Categoria"].Value != null && fila.Cells["Id_Categoria"].Value != DBNull.Value)
            {
                int idCategoriaRow = Convert.ToInt32(fila.Cells["Id_Categoria"].Value);
                txtCategoriamate.SelectedValue = idCategoriaRow;
            }
            else
            {
                txtCategoriamate.SelectedIndex = -1;
            }

            txtCategoriamate.Enabled = true;
            txtminimost.Enabled = true;
            txtunidadmedida.Enabled = true;
            IconGuardarm.Enabled = false;
        }


        private async void iconeditar_Click_1(object sender, EventArgs e)
        {


            try
            {
                if (_idMateSeleccionado == null || _idMateSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor, seleccione un material de la tabla para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtmaterial.Text) ||
                    string.IsNullOrWhiteSpace(txtstock.Text) ||
                    string.IsNullOrWhiteSpace(txtminimost.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoriamate.Text) ||
                    string.IsNullOrWhiteSpace(txtxprecio.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCategoria = txtCategoriamate.SelectedValue != null ? Convert.ToInt32(txtCategoriamate.SelectedValue) : 0;

                MaterialEntity materialModificado = new MaterialEntity
                (
                    txtmaterial.Text.Trim(),
                    idCategoria,
                    txtunidadmedida.Text.Trim(),
                    Convert.ToInt32(txtstock.Text),
                    Convert.ToInt32(txtminimost.Text),
                    Convert.ToDecimal(txtxprecio.Text)
                );




                materialModificado.AsignarId(_idMateSeleccionado.Value);

                await _materialBll.ActualizarMaterial(materialModificado);

                MessageBox.Show("¡Material actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                _idMateSeleccionado = null;
                IconGuardarm.Enabled = true;

                await MostrarMaterialAsincrono();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dgvmateril_Paint(object sender, PaintEventArgs e)
        {
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Dibuja el contorno redondeado del panel de manera limpia
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radio = 20;
                    Rectangle rect = new Rectangle(0, 0, dgvmateril.Width - 1, dgvmateril.Height - 1);

                    path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                    path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                    path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                    path.CloseFigure();

                    dgvmateril.Region = new Region(path);
                }
            }
        }
    }
}
