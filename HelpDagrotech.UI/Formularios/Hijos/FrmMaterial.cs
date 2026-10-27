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
        private string rutaImagenSeleccionada;

        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void IconGuardarm_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
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
                dgvmaterial.DataSource = null;
                dgvmaterial.DataSource = lista;

                configurarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cragra los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void configurarDataGrid()
        {
            if (dgvmaterial.Columns.Count == 0)
                return;


            if (dgvmaterial.Columns["Id"] != null)
                dgvmaterial.Columns["Id"].Visible = false;
            if (dgvmaterial.Columns["Id_Categoria"] != null)
                dgvmaterial.Columns["Id_Categoria"].Visible = false;

            if (dgvmaterial.Columns["Nombre_material"] != null)
                dgvmaterial.Columns["Nombre_material"].HeaderText = "Material";
            if (dgvmaterial.Columns["Nombre_categoria"] != null)
                dgvmaterial.Columns["Nombre_categoria"].HeaderText = "Categoria";
            if (dgvmaterial.Columns["Unidad_material"] != null)
                dgvmaterial.Columns["Unidad_material"].HeaderText = "Unidad de medida";
            if (dgvmaterial.Columns["Stock"] != null)
                dgvmaterial.Columns["Stock"].HeaderText = "Stock";
            if (dgvmaterial.Columns["Stock_minimo"] != null)
                dgvmaterial.Columns["Stock_minimo"].HeaderText = "Stock minimo";
            // if (dgvlistadoEmpleado.Columns["Contrasena"] != null)
            //    dgvlistadoEmpleado.Columns["Contrasena"].HeaderText = "Contraseña";
            if (dgvmaterial.Columns["Precio"] != null)
                dgvmaterial.Columns["Precio"].HeaderText = "Precio";

            if (dgvmaterial.Columns["Nombre_material"] != null)
                dgvmaterial.Columns["Nombre_material"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /*private async Task CargarRolesAsync()
         {
             try
             {
                 var categoria = await _categoriaMaterialDal.MostrarCategoriasAsync();

                 txtCategoriamate.DataSource = categoria;
                 txtCategoriamate.DisplayMember = "Nombre_categoria";
                 txtCategoriamate.ValueMember = "Id_Categoria";
                 txtCategoriamate.SelectedIndex = -1;
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al cargar las categorias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/

        private void CargarCategoriasYUnidades()
        {

            {
                Dictionary<int, string> categorias = new Dictionary<int, string>()
            {
                { 1, "Fertilizantes" },
                { 2, "Semillas" },
                { 3, "Agroquímicos" },
                { 4, "Herramientas" }
            };

                txtCategoriamate.DataSource = new BindingSource(categorias, null);
                txtCategoriamate.DisplayMember = "Value";
                txtCategoriamate.ValueMember = "Key";
                txtCategoriamate.SelectedIndex = -1;

                txtunidadmedida.Items.Clear();
                txtunidadmedida.Items.Add("Kilogramos (kg)");
                txtunidadmedida.Items.Add("Litros (L)");
                txtunidadmedida.Items.Add("Sacos");
                txtunidadmedida.Items.Add("Unidades");
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

        private void dgvmaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void txtbuscarMaterial_TextChanged(object sender, EventArgs e)
        {
            await MostrarMaterialAsincrono();
        }

        private async void FrmMaterial_Load_1(object sender, EventArgs e)
        {
            CargarCategoriasYUnidades();
            await MostrarMaterialAsincrono();
        }

        private async void txtbuscarMaterial_TextChanged_1(object sender, EventArgs e)
        {
            await MostrarMaterialAsincrono();
        }
    }
}
