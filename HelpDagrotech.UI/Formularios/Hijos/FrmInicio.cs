using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using HelpDagrotech.UI.Helpers;
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
using System.Windows.Forms;

namespace HelpDagrotech.UI.Formularios
{
    public partial class FrmCultivo : Form
    {
        private bool EsEdicion = false;
        private readonly SiembraBll _siembraBll = new SiembraBll();
        public FrmCultivo()
        {
            InitializeComponent();
        }


        private void CargarMarcadoresTerrenos()
        {
            // Creamos la capa contenedora de los marcadores
            GMapOverlay capaTerrenos = new GMapOverlay("banderas_terrenos");

            // --- EJEMPLO DE DATOS (Aquí conectarás tu Capa de Negocio / DataTable de la BD) ---
            // Simulación de coordenadas de terrenos agrícolas
            double latitudTerreno = 12.1500;
            double longitudTerreno = -86.2700;
            string nombreTerreno = "Lote Norte - Maíz";

            PointLatLng ubicacion = new PointLatLng(latitudTerreno, longitudTerreno);

            // Creamos el marcador con estilo de bandera (puedes cambiar el color según el estado)
            GMarkerGoogle marcador = new GMarkerGoogle(ubicacion, GMarkerGoogleType.red);

            // Agregamos un texto emergente (Tooltip) al pasar el cursor sobre la bandera
            marcador.ToolTipText = $"Terreno: {nombreTerreno}\nEstado: Activo";
            marcador.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            // Añadimos el marcador a la capa
            capaTerrenos.Markers.Add(marcador);
            // ----------------------------------------------------------------------------------

            // Limpiamos capas previas e insertamos la nueva capa en el control del mapa
            gMapAgroT.Overlays.Clear();
            gMapAgroT.Overlays.Add(capaTerrenos);

            // Refrescamos para que se rendericen las banderas
            gMapAgroT.Refresh();
        }

        private void btnActualizarMapa_Click(object sender, EventArgs e)
        {
            // Este es el evento de tu botón "Actualizar Mapa con Datos de Siembra"
            CargarMarcadoresTerrenos();
            MessageBox.Show("¡Mapa actualizado correctamente con los datos operativos!", "AgroTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gMapAgroT_Load(object sender, EventArgs e)
        {

        }

        private void paneldeCultivo_Paint(object sender, PaintEventArgs e)

        {

        }

        private void txtsemilava_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void bttGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                if (!EsEdicion)
                {
                    SiembraEntity nuevo = new SiembraEntity
                    {
                        Id_Terreno = Convert.ToInt32(Cboxterreno.SelectedValue),
                        Id_Cultivo = Convert.ToInt32(CboxSemilla.SelectedValue),
                        Duracion = txtcosechaestim.Text.Trim(),
                        Fecha = DateTime.Now
                    };

                    await _siembraBll.InsertarSiembraAsync(
                        nuevo.Id_Terreno,
                        nuevo.Id_Cultivo,
                        nuevo.Duracion,
                        nuevo.Fecha
                    );

                    MessageBox.Show("¡Siembra agregada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    // Lógica de actualización / edición si aplica
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Recarga la tabla de forma asíncrona para mostrar el nuevo registro al instante
            await CargarCultivosAsync();
        }


        private void LimpiarFormulario()
        {
            CboxSemilla.SelectedIndex = -1;
            Cboxterreno.SelectedIndex = -1;
            txtcosechaestim.Clear();
        }
        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool valido = true;

            // Validar ComboBox de Terreno
            if (Cboxterreno.SelectedValue == null || Cboxterreno.SelectedIndex == -1)
            {
                errorProvider1.SetError(Cboxterreno, "Debe seleccionar un terreno.");
                valido = false;
            }

            // Validar ComboBox de Cultivo
            if (CboxSemilla.SelectedValue == null || CboxSemilla.SelectedIndex == -1)
            {
                errorProvider1.SetError(CboxSemilla, "Debe seleccionar un cultivo.");
                valido = false;
            }

            // Validar campo de Duración
            if (!ValidarHelper.Requerido(txtcosechaestim, errorProvider1, "Debe ingresar la duración de la siembra."))
                valido = false;

            // Validar fecha si lo requiere el control
            if (txtSimebra.Value > DateTime.Now.AddYears(1))
            {
                errorProvider1.SetError(txtSimebra, "Verifique la fecha de siembra.");
                valido = false;
            }

            return valido;
        }
        private async Task CargarCultivosAsync()
        {
            try
            {
                CultivoBll cultivoBll = new CultivoBll();
                var cultivos = await cultivoBll.MostrarCultivosAsincrono();

                CboxSemilla.DataSource = cultivos;
                CboxSemilla.DisplayMember = "Nombre";    // Coincide con la columna de SQL
                CboxSemilla.ValueMember = "Id_Cultivo";  // Clave primaria
                CboxSemilla.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los cultivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task MostrarTerrenosAsincrono()
        {
            try
            {
                TerrenoDal _terrenoDal = new TerrenoDal();
                var terrenos = await _terrenoDal.MostrarTerrenosAsincrono();

                Cboxterreno.DataSource = terrenos;
                Cboxterreno.DisplayMember = "Nombre_T";
                Cboxterreno.ValueMember = "Id_Terreno";
                Cboxterreno.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los terrenos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmCultivo_Load(object sender, EventArgs e)
        {
            await CargarCultivosAsync();
            await MostrarTerrenosAsincrono();
        }

        private void Cboxterreno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttregistrarcosecha_Click(object sender, EventArgs e)
        {

        }
    }
}