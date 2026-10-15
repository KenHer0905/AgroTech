using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
        public FrmCultivo()
        {
            InitializeComponent();
        }

        private void FrmAgroT_Load(object sender, EventArgs e)
        {
            // Inicializamos el mapa al cargar el formulario
            ConfigurarMapa();
        }

        private void ConfigurarMapa()
        {
            // 1. Indicar el modo de acceso a los servidores del mapa
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            // 2. Asignar el proveedor del mapa (OpenStreetMap es gratuito y no requiere API Key)
            gMapAgroT.MapProvider = GMapProviders.OpenStreetMap;

            // 3. Coordenadas iniciales para centrar el mapa (Ej: Managua / Nicaragua)
            gMapAgroT.Position = new PointLatLng(12.1328, -86.2504);

            // 4. Configurar niveles de Zoom
            gMapAgroT.MinZoom = 3;
            gMapAgroT.MaxZoom = 24;
            gMapAgroT.Zoom = 10; // Zoom inicial adecuado para ver regiones/lotes

            // 5. Configurar comportamiento del mouse
            gMapAgroT.DragButton = MouseButtons.Left;
            gMapAgroT.CanDragMap = true;
            gMapAgroT.ShowTileGridLines = false;
            gMapAgroT.AutoScroll = true;

            // 6. Cargar los pines o banderas de los terrenos
            CargarMarcadoresTerrenos();
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
    }
}