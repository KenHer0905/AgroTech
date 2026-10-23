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

        private void IconGuardarm_Click(object sender, EventArgs e)
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
                
                string conexionString = "Server=.; Database=Agrotechdb; Integrated Security=true;";
                

                using (System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(conexionString))
                {
                    conexion.Open();

                    string query = "INSERT INTO Material (Nombre_material, Id_Categoria, Unidad_material, Stock, Stock_minimo, Precio) " +
                                   "VALUES (@nombre, @categoria, @unidad, @stock, @stockMin, @precio)";

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtmaterial.Text);
                        cmd.Parameters.AddWithValue("@categoria", 1);
                        cmd.Parameters.AddWithValue("@unidad", txtunidadmedida.Text);
                        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtstock.Text));
                        cmd.Parameters.AddWithValue("@stockMin", Convert.ToInt32(txtminimost.Text));
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtxprecio.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

               
                dgvmaterial.Rows.Add(txtmaterial.Text, txtCategoriamate.Text, txtdescrip.Text, txtstock.Text, txtminimost.Text, txtxprecio.Text, txtunidadmedida.Text);

                MessageBox.Show("Material registrado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           
            txtCategoriamate.Items.Clear();
            txtCategoriamate.Items.Add("Fertilizantes");
            txtCategoriamate.Items.Add("Semillas");
            txtCategoriamate.Items.Add("Agroquímicos");
            txtCategoriamate.Items.Add("Herramientas");

            txtunidadmedida.Items.Clear();
            txtunidadmedida.Items.Add("Kilogramos (kg)");
            txtunidadmedida.Items.Add("Litros (L)");
            txtunidadmedida.Items.Add("Sacos");
            txtunidadmedida.Items.Add("Unidades");
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
