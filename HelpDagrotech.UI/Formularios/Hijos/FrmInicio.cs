using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using HelpDagrotech.UI.Formularios.Hijos;
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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace HelpDagrotech.UI.Formularios
{
    public partial class FrmCultivo : Form
    {
        private bool EsEdicion = false;
        private readonly SiembraDal _dal = new SiembraDal();

        private int? _idTerreSeleccionado = null;



        public FrmCultivo()
        {
            InitializeComponent();
        }


        private void CargarMarcadoresTerrenos()
        {

            GMapOverlay capaTerrenos = new GMapOverlay("banderas_terrenos");

            double latitudTerreno = 12.1500;
            double longitudTerreno = -86.2700;
            string nombreTerreno = "Lote Norte - Maíz";

            PointLatLng ubicacion = new PointLatLng(latitudTerreno, longitudTerreno);

            GMarkerGoogle marcador = new GMarkerGoogle(ubicacion, GMarkerGoogleType.red);


            marcador.ToolTipText = $"Terreno: {nombreTerreno}\nEstado: Activo";
            marcador.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            capaTerrenos.Markers.Add(marcador);

            gMapAgroT.Overlays.Clear();
            gMapAgroT.Overlays.Add(capaTerrenos);

            gMapAgroT.Refresh();


        }

        private void btnActualizarMapa_Click(object sender, EventArgs e)
        {
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
            {
                this.BeginInvoke((Action)(() =>
                {
                    // 1. Configurar el mapa y el User-Agent
                    GMap.NET.MapProviders.OpenStreetMapProvider.UserAgent = "HelpDagrotechApp/1.0 (contacto@tucorreo.com)";
                    gMapAgroT.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                    GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

                    double lat = 11.539626;
                    double lng = -85.608108;

                    gMapAgroT.Position = new GMap.NET.PointLatLng(lat, lng);
                    gMapAgroT.MinZoom = 16;
                    gMapAgroT.MaxZoom = 16;
                    gMapAgroT.Zoom = 16;
                    gMapAgroT.CanDragMap = false; // Bloquear movimiento

                    // 2. Crear la capa para las parcelas ordenadas y limpias
                    GMapOverlay capaLotes = new GMapOverlay("capa_lotes");

                    // --- LOTE #1 (Izquierda superior) ---
                    List<GMap.NET.PointLatLng> p1 = new List<GMap.NET.PointLatLng>();
                    p1.Add(new GMap.NET.PointLatLng(lat + 0.0030, lng - 0.0035));
                    p1.Add(new GMap.NET.PointLatLng(lat + 0.0025, lng - 0.0010));
                    p1.Add(new GMap.NET.PointLatLng(lat + 0.0002, lng - 0.0010));
                    p1.Add(new GMap.NET.PointLatLng(lat + 0.0005, lng - 0.0033));
                    GMapPolygon poly1 = new GMapPolygon(p1, "#1");
                    poly1.Fill = new SolidBrush(Color.FromArgb(170, 156, 204, 101));
                    poly1.Stroke = new Pen(Color.White, 3);
                    capaLotes.Polygons.Add(poly1);

                    // --- LOTE #2 (Centro superior) ---
                    List<GMap.NET.PointLatLng> p2 = new List<GMap.NET.PointLatLng>();
                    p2.Add(new GMap.NET.PointLatLng(lat + 0.0032, lng - 0.0008));
                    p2.Add(new GMap.NET.PointLatLng(lat + 0.0028, lng + 0.0018));
                    p2.Add(new GMap.NET.PointLatLng(lat + 0.0004, lng + 0.0018));
                    p2.Add(new GMap.NET.PointLatLng(lat + 0.0002, lng - 0.0008));
                    GMapPolygon poly2 = new GMapPolygon(p2, "#2");
                    poly2.Fill = new SolidBrush(Color.FromArgb(170, 46, 125, 50));
                    poly2.Stroke = new Pen(Color.White, 3);
                    capaLotes.Polygons.Add(poly2);

                    // --- LOTE #3 (Derecha superior) ---
                    List<GMap.NET.PointLatLng> p3 = new List<GMap.NET.PointLatLng>();
                    p3.Add(new GMap.NET.PointLatLng(lat + 0.0026, lng + 0.0020));
                    p3.Add(new GMap.NET.PointLatLng(lat + 0.0022, lng + 0.0045));
                    p3.Add(new GMap.NET.PointLatLng(lat - 0.0002, lng + 0.0043));
                    p3.Add(new GMap.NET.PointLatLng(lat + 0.0002, lng + 0.0020));
                    GMapPolygon poly3 = new GMapPolygon(p3, "#3");
                    poly3.Fill = new SolidBrush(Color.FromArgb(170, 120, 180, 90));
                    poly3.Stroke = new Pen(Color.White, 3);
                    capaLotes.Polygons.Add(poly3);

                    // --- LOTE #4 (Izquierda inferior) ---
                    List<GMap.NET.PointLatLng> p4 = new List<GMap.NET.PointLatLng>();
                    p4.Add(new GMap.NET.PointLatLng(lat - 0.0000, lng - 0.0032));
                    p4.Add(new GMap.NET.PointLatLng(lat - 0.0003, lng - 0.0010));
                    p4.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng - 0.0012));
                    p4.Add(new GMap.NET.PointLatLng(lat - 0.0022, lng - 0.0030));
                    GMapPolygon poly4 = new GMapPolygon(p4, "#4");
                    poly4.Fill = new SolidBrush(Color.FromArgb(170, 104, 159, 56));
                    poly4.Stroke = new Pen(Color.White, 3);
                    capaLotes.Polygons.Add(poly4);

                    // --- LOTE #5 (Centro inferior) ---
                    List<GMap.NET.PointLatLng> p5 = new List<GMap.NET.PointLatLng>();
                    p5.Add(new GMap.NET.PointLatLng(lat - 0.0000, lng - 0.0008));
                    p5.Add(new GMap.NET.PointLatLng(lat - 0.0002, lng + 0.0018));
                    p5.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng + 0.0016));
                    p5.Add(new GMap.NET.PointLatLng(lat - 0.0023, lng - 0.0010));
                    GMapPolygon poly5 = new GMapPolygon(p5, "#5");
                    poly5.Fill = new SolidBrush(Color.FromArgb(170, 180, 220, 140));
                    poly5.Stroke = new Pen(Color.White, 3);
                    capaLotes.Polygons.Add(poly5);

                    // --- LOTE #6 (Derecha inferior) ---
                    List<GMap.NET.PointLatLng> p6 = new List<GMap.NET.PointLatLng>();
                    p6.Add(new GMap.NET.PointLatLng(lat - 0.0004, lng + 0.0020));
                    p6.Add(new GMap.NET.PointLatLng(lat - 0.0002, lng + 0.0043));
                    p6.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng + 0.0040));
                    p6.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng + 0.0018));
                    GMapPolygon poly6 = new GMapPolygon(p6, "#6");
                    poly6.Fill = new SolidBrush(Color.FromArgb(170, 34, 100, 38));
                    poly6.Stroke = new Pen(Color.White, 3);
                    capaLotes.Polygons.Add(poly6);

                    // 3. Añadir la capa y refrescar el mapa
                    gMapAgroT.Overlays.Add(capaLotes);
                    gMapAgroT.Refresh();
                }));


            }
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

                    await _dal.InsertarSiembraAsync(
                        nuevo.Id_Terreno,
                        nuevo.Id_Cultivo,
                        nuevo.Duracion,
                        nuevo.Fecha
                    );

                    MessageBox.Show("¡Siembra agregada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    await MostrarSiembraAsincrono();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("Detalle del error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

            if (Cboxterreno.SelectedValue == null || Cboxterreno.SelectedIndex == -1)
            {
                errorProvider1.SetError(Cboxterreno, "Debe seleccionar un terreno.");
                valido = false;
            }

            if (CboxSemilla.SelectedValue == null || CboxSemilla.SelectedIndex == -1)
            {
                errorProvider1.SetError(CboxSemilla, "Debe seleccionar un cultivo.");
                valido = false;
            }

            if (!ValidarHelper.Requerido(txtcosechaestim, errorProvider1, "Debe ingresar la duración de la siembra."))
                valido = false;

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

        private async Task CargarListadoAsincrono()
        {
            try
            {
                List<SiembraEntity> lista = await
                   _dal.MostrarSiembraAsincrono(txtbuscarSiembra.Text.Trim());
                dvgSiembralis.DataSource = null;
                dvgSiembralis.DataSource = lista;

                configurarDataGridSiembra();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cragra los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void configurarDataGridSiembra()
        {
            if (dvgSiembralis.Columns.Count == 0)
                return;
            if (dvgSiembralis.Columns["Id_Siembra"] != null)
                dvgSiembralis.Columns["Id_Siembra"].Visible = false;
            if (dvgSiembralis.Columns["Id_Terreno"] != null)
                dvgSiembralis.Columns["Id_Terreno"].Visible = false;
            if (dvgSiembralis.Columns["Id_Cultivo"] != null)
                dvgSiembralis.Columns["Id_Cultivo"].Visible = false;

            if (dvgSiembralis.Columns["NombreTerreno"] != null)
                dvgSiembralis.Columns["NombreTerreno"].HeaderText = "Terreno";

            if (dvgSiembralis.Columns["Nombre"] != null)
                dvgSiembralis.Columns["Nombre"].HeaderText = "Cultivo";

            if (dvgSiembralis.Columns["Duracion"] != null)
                dvgSiembralis.Columns["Duracion"].HeaderText = "Duración";

            if (dvgSiembralis.Columns["Fecha"] != null)
                dvgSiembralis.Columns["Fecha"].HeaderText = "Fecha de Siembra";

            if (dvgSiembralis.Columns["NombreTerreno"] != null)
                dvgSiembralis.Columns["NombreTerreno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dvgSiembralis.Columns["Nombre"] != null)
                dvgSiembralis.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async void FrmCultivo_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                // 1. Configurar el mapa y el User-Agent
                GMap.NET.MapProviders.OpenStreetMapProvider.UserAgent = "HelpDagrotechApp/1.0 (contacto@tucorreo.com)";
                gMapAgroT.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

                double lat = 11.539626;
                double lng = -85.608108;

                gMapAgroT.Position = new GMap.NET.PointLatLng(lat, lng);
                gMapAgroT.MinZoom = 16;
                gMapAgroT.MaxZoom = 16;
                gMapAgroT.Zoom = 16;
                gMapAgroT.CanDragMap = false; // Bloquear movimiento

                // 2. Crear la capa para las parcelas ordenadas y limpias
                GMapOverlay capaLotes = new GMapOverlay("capa_lotes");

                // --- LOTE #1 (Izquierda superior) ---
                List<GMap.NET.PointLatLng> p1 = new List<GMap.NET.PointLatLng>();
                p1.Add(new GMap.NET.PointLatLng(lat + 0.0030, lng - 0.0035));
                p1.Add(new GMap.NET.PointLatLng(lat + 0.0025, lng - 0.0010));
                p1.Add(new GMap.NET.PointLatLng(lat + 0.0002, lng - 0.0010));
                p1.Add(new GMap.NET.PointLatLng(lat + 0.0005, lng - 0.0033));
                GMapPolygon poly1 = new GMapPolygon(p1, "#1");
                poly1.Fill = new SolidBrush(Color.FromArgb(170, 156, 204, 101));
                poly1.Stroke = new Pen(Color.White, 3);
                capaLotes.Polygons.Add(poly1);

                // --- LOTE #2 (Centro superior) ---
                List<GMap.NET.PointLatLng> p2 = new List<GMap.NET.PointLatLng>();
                p2.Add(new GMap.NET.PointLatLng(lat + 0.0032, lng - 0.0008));
                p2.Add(new GMap.NET.PointLatLng(lat + 0.0028, lng + 0.0018));
                p2.Add(new GMap.NET.PointLatLng(lat + 0.0004, lng + 0.0018));
                p2.Add(new GMap.NET.PointLatLng(lat + 0.0002, lng - 0.0008));
                GMapPolygon poly2 = new GMapPolygon(p2, "#2");
                poly2.Fill = new SolidBrush(Color.FromArgb(170, 46, 125, 50));
                poly2.Stroke = new Pen(Color.White, 3);
                capaLotes.Polygons.Add(poly2);

                // --- LOTE #3 (Derecha superior) ---
                List<GMap.NET.PointLatLng> p3 = new List<GMap.NET.PointLatLng>();
                p3.Add(new GMap.NET.PointLatLng(lat + 0.0026, lng + 0.0020));
                p3.Add(new GMap.NET.PointLatLng(lat + 0.0022, lng + 0.0045));
                p3.Add(new GMap.NET.PointLatLng(lat - 0.0002, lng + 0.0043));
                p3.Add(new GMap.NET.PointLatLng(lat + 0.0002, lng + 0.0020));
                GMapPolygon poly3 = new GMapPolygon(p3, "#3");
                poly3.Fill = new SolidBrush(Color.FromArgb(170, 120, 180, 90));
                poly3.Stroke = new Pen(Color.White, 3);
                capaLotes.Polygons.Add(poly3);

                // --- LOTE #4 (Izquierda inferior) ---
                List<GMap.NET.PointLatLng> p4 = new List<GMap.NET.PointLatLng>();
                p4.Add(new GMap.NET.PointLatLng(lat - 0.0000, lng - 0.0032));
                p4.Add(new GMap.NET.PointLatLng(lat - 0.0003, lng - 0.0010));
                p4.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng - 0.0012));
                p4.Add(new GMap.NET.PointLatLng(lat - 0.0022, lng - 0.0030));
                GMapPolygon poly4 = new GMapPolygon(p4, "#4");
                poly4.Fill = new SolidBrush(Color.FromArgb(170, 104, 159, 56));
                poly4.Stroke = new Pen(Color.White, 3);
                capaLotes.Polygons.Add(poly4);

                // --- LOTE #5 (Centro inferior) ---
                List<GMap.NET.PointLatLng> p5 = new List<GMap.NET.PointLatLng>();
                p5.Add(new GMap.NET.PointLatLng(lat - 0.0000, lng - 0.0008));
                p5.Add(new GMap.NET.PointLatLng(lat - 0.0002, lng + 0.0018));
                p5.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng + 0.0016));
                p5.Add(new GMap.NET.PointLatLng(lat - 0.0023, lng - 0.0010));
                GMapPolygon poly5 = new GMapPolygon(p5, "#5");
                poly5.Fill = new SolidBrush(Color.FromArgb(170, 180, 220, 140));
                poly5.Stroke = new Pen(Color.White, 3);
                capaLotes.Polygons.Add(poly5);

                // --- LOTE #6 (Derecha inferior) ---
                List<GMap.NET.PointLatLng> p6 = new List<GMap.NET.PointLatLng>();
                p6.Add(new GMap.NET.PointLatLng(lat - 0.0004, lng + 0.0020));
                p6.Add(new GMap.NET.PointLatLng(lat - 0.0002, lng + 0.0043));
                p6.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng + 0.0040));
                p6.Add(new GMap.NET.PointLatLng(lat - 0.0025, lng + 0.0018));
                GMapPolygon poly6 = new GMapPolygon(p6, "#6");
                poly6.Fill = new SolidBrush(Color.FromArgb(170, 34, 100, 38));
                poly6.Stroke = new Pen(Color.White, 3);
                capaLotes.Polygons.Add(poly6);

                // 3. Añadir la capa y refrescar el mapa
                gMapAgroT.Overlays.Add(capaLotes);
                gMapAgroT.Refresh();




            }));


            await CargarCultivosAsync();
            await MostrarTerrenosAsincrono();
            await MostrarSiembraAsincrono();
        }

        private void Cboxterreno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttregistrarcosecha_Click(object sender, EventArgs e)
        {

        }

        private void CboxSemilla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void txtbuscarSiembra_TextChanged(object sender, EventArgs e)
        {
            await MostrarSiembraAsincrono();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dvgSiembralis.Rows[e.RowIndex];

            if (fila.Cells["Id_Siembra"].Value != null)
            {
                _idTerreSeleccionado = Convert.ToInt32(fila.Cells["Id_Siembra"].Value);
            }

            txtcosechaestim.Text = fila.Cells["Duracion"].Value?.ToString();

            if (fila.Cells["Fecha"].Value != null && fila.Cells["Fecha"].Value != DBNull.Value)
            {
                txtSimebra.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
            }

            if (fila.Cells["Id_Terreno"].Value != null && fila.Cells["Id_Terreno"].Value != DBNull.Value)
            {
                int idTerrenoRow = Convert.ToInt32(fila.Cells["Id_Terreno"].Value);
                Cboxterreno.SelectedValue = idTerrenoRow;
            }
            else
            {
                Cboxterreno.SelectedIndex = -1;
            }
            if (fila.Cells["Id_Cultivo"].Value != null && fila.Cells["Id_Cultivo"].Value != DBNull.Value)
            {
                int idCultivoRow = Convert.ToInt32(fila.Cells["Id_Cultivo"].Value);
                CboxSemilla.SelectedValue = idCultivoRow;
            }
            else
            {
                CboxSemilla.SelectedIndex = -1;
            }

            Cboxterreno.Enabled = true;
            CboxSemilla.Enabled = true;
            txtcosechaestim.Enabled = true;
            txtSimebra.Enabled = true;


            bttGuardar.Enabled = false;
        }

        private async void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idTerreSeleccionado == null || _idTerreSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor, seleccione una siembra de la tabla para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtcosechaestim.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idTerreno = Cboxterreno.SelectedValue != null ? Convert.ToInt32(Cboxterreno.SelectedValue) : 0;
                int idCultivo = CboxSemilla.SelectedValue != null ? Convert.ToInt32(CboxSemilla.SelectedValue) : 0;

                if (idTerreno == 0 || idCultivo == 0)
                {
                    MessageBox.Show("Por favor, seleccione un terreno y un cultivo válidos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SiembraEntity siembraModificada = new SiembraEntity
                {
                    Id_Siembra = _idTerreSeleccionado.Value,
                    Id_Terreno = idTerreno,
                    Id_Cultivo = idCultivo,
                    Duracion = txtcosechaestim.Text.Trim(),
                    Fecha = txtSimebra.Value
                };

                await _dal.ActualizarSiembraAsync(siembraModificada);

                MessageBox.Show("Siembra actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                LimpiarFormulario();
                _idTerreSeleccionado = null;
                bttGuardar.Enabled = true;

                await MostrarSiembraAsincrono();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task MostrarSiembraAsincrono()
        {
            try
            {
                List<SiembraEntity> lista = await
                   _dal.MostrarSiembraAsincrono(txtbuscarSiembra.Text.Trim());
                dvgSiembralis.DataSource = null;
                dvgSiembralis.DataSource = lista;

                configurarDataGridSiembra();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al carga los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FrmCultivo_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
        }

        private void gMapAgroT_Load_1(object sender, EventArgs e)
        {

        }

        private void gMapAgroT_OnPolygonClick(GMap.NET.WindowsForms.GMapPolygon polygon, MouseEventArgs e)
        {
            if (polygon.Tag != null && int.TryParse(polygon.Tag.ToString(), out int id))
            {
                Cboxterreno.SelectedValue = id;
            }
        }

        private void dvgSiembralis_Paint(object sender, PaintEventArgs e)
        {
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Dibuja el contorno redondeado del panel de manera limpia
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radio = 20;
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, dvgSiembralis.Width - 1, dvgSiembralis.Height - 1);
                    path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                    path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                    path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                    path.CloseFigure();

                    dvgSiembralis.Region = new Region(path);
                }
            }
        }
    }
}