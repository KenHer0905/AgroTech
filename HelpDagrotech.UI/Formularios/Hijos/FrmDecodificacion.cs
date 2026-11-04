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

namespace HelpDagrotech.UI.Formularios.Hijos
{
    public partial class FrmDecodificacion : Form

    {
        private readonly CultivoDal _dal = new CultivoDal();
        private readonly DecodificacionBll _bll = new DecodificacionBll();
        private readonly MaterialDal _materialBll = new MaterialDal();
        public FrmDecodificacion()
        {
            InitializeComponent();
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void bttguardarDeco_Click(object sender, EventArgs e)
        {
            if (Cboxmaterial.SelectedValue == null || Cboxcultivo.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un Material y un Cultivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idMaterial = Convert.ToInt32(Cboxmaterial.SelectedValue);
                int idCultivo = Convert.ToInt32(Cboxcultivo.SelectedValue);
                decimal cantidadArea = CantAreanum.Value; // Asegúrate de que tu control numérico se llame así
                string etapaAplicaciona = txxtetapa.Text.Trim();

                await _bll.InsertarMaterialCultAsync(idMaterial, idCultivo, cantidadArea, etapaAplicaciona);

                MessageBox.Show("¡Dosificación guardada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                await CargarGridAsync(); // Recarga la tabla automáticamente para que se vea el nuevo registro
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmDecodificacion_Load(object sender, EventArgs e)
        {
            await CargarCombosMaterialesAsync();
            await CargarGridAsync();
            await CargarComboCultivoesAsync();
        }
        private async Task CargarComboCultivoesAsync()
        {
            try
            {
                CultivoDal _dal = new CultivoDal();
                var lista = await _dal.MostrarCultivosAsincrono();

                Cboxcultivo.DataSource = lista;
                Cboxcultivo.DisplayMember = "Nombre";
                Cboxcultivo.ValueMember = "Id_Cultivo";
                Cboxcultivo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los materiales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task CargarCombosMaterialesAsync()
        {
            try
            {
                MaterialBll materialBll = new MaterialBll();
                var listaMateriales = await materialBll.MostrarMaterialAsincrono();

                Cboxmaterial.DataSource = listaMateriales;
                Cboxmaterial.DisplayMember = "Nombre_material";
                Cboxmaterial.ValueMember = "Id_Material";
                Cboxmaterial.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los materiales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    


        private async Task CargarGridAsync(string buscar = null)
        {
            try
            {
                var resultado = await _bll.MostrarMaterialCultAsincrono(buscar);
                dvgdeco.DataSource = resultado; // Asegúrate de que tu DataGridView se llame así
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            Cboxmaterial.SelectedIndex = -1;
            Cboxcultivo.SelectedIndex = -1;
            CantAreanum.Value = 0;
            txxtetapa.Clear();
        }

        private void dvgdeco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cboxcultivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cboxmaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
