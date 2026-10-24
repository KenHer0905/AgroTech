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

namespace HelpDagrotech.UI.Formularios
{
    public partial class FrmMaterial : Form
    {
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

                // para mirarlo en el data griew
                dgvmaterial.Rows.Add(txtmaterial.Text, txtCategoriamate.Text, txtdescrip.Text, txtstock.Text, txtminimost.Text, txtxprecio.Text, txtunidadmedida.Text);

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

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            CargarCategoriasYUnidades();
        }


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
    }
}
