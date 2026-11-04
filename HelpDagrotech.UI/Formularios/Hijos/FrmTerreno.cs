using GMap.NET.WindowsForms;
using HelpDagrotech.UI.Helpers;
using HelpDAgroTech.Bll;
using HelpDAgroTech.Bll.Common;
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

namespace HelpDagrotech.UI.Formularios
{
    public partial class FrmTerreno : Form
    {
        private readonly TerrenoBll _terrenoBLL = new TerrenoBll();
        private int? _idTerrenoSeleccionado = null;
        public bool EsEdicion => _idTerrenoSeleccionado.HasValue;
        public FrmTerreno()
        {
            InitializeComponent();
        }


        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            {
                this.BeginInvoke((Action)(() =>
                {
                    // 1. Configurar el mapa y el User-Agent
                    GMap.NET.MapProviders.OpenStreetMapProvider.UserAgent = "HelpDagrotechApp/1.0 (contacto@tucorreo.com)";
                    gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                    GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

                    double lat = 11.539626;
                    double lng = -85.608108;

                    gMapControl1.Position = new GMap.NET.PointLatLng(lat, lng);
                    gMapControl1.MinZoom = 16;
                    gMapControl1.MaxZoom = 16;
                    gMapControl1.Zoom = 16;
                    gMapControl1.CanDragMap = false; // Bloquear movimiento

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
                    gMapControl1.Overlays.Add(capaLotes);
                    gMapControl1.Refresh();
                }));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = DatagridTerreno.Rows[e.RowIndex];

            if (fila.Cells["Id_Terreno"].Value != null)
            {
                _idTerrenoSeleccionado = Convert.ToInt32(fila.Cells["Id_Terreno"].Value);
            }

            txtterrenp.Text = fila.Cells["Nombre_T"].Value?.ToString();
            txtareat.Text = fila.Cells["Area"].Value?.ToString();
            txtubica.Text = fila.Cells["Ubicacion"].Value?.ToString();
            txtlatitu.Text = fila.Cells["Latitud"].Value?.ToString();
            txtlongi.Text = fila.Cells["Longitud"].Value?.ToString();

            BtnGuardarTerreno.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTerreno_Paint(object sender, PaintEventArgs e)
        {
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

        private void configurarDataGrid()
        {
            if (DatagridTerreno.Columns.Count == 0)
                return;

            if (DatagridTerreno.Columns["Id_Terreno"] != null)
                DatagridTerreno.Columns["Id_Terreno"].Visible = false;
            if (DatagridTerreno.Columns["Latitud"] != null)
                DatagridTerreno.Columns["Latitud"].Visible = false;
            if (DatagridTerreno.Columns["Longitud"] != null)
                DatagridTerreno.Columns["Longitud"].Visible = false;

            if (DatagridTerreno.Columns["Nombre_T"] != null)
                DatagridTerreno.Columns["Nombre_T"].HeaderText = "Nombre del Terreno";
            if (DatagridTerreno.Columns["Area"] != null)
                DatagridTerreno.Columns["Area"].HeaderText = "Area";
            if (DatagridTerreno.Columns["EstadoT"] != null)
                DatagridTerreno.Columns["EstadoT"].HeaderText = "Estado";
            if (DatagridTerreno.Columns["Ubicacion"] != null)
                DatagridTerreno.Columns["Ubicacion"].HeaderText = "Ubicación";

            if (DatagridTerreno.Columns["Ubicacion"] != null)
                DatagridTerreno.Columns["Ubicacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async Task CargarListadoAsincrono()
        {
            try
            {
                List<TerrenoEntity> lista = await
                    _terrenoBLL.MostrarTerrenosAsincrono(txtbuscarTerreno.Text.Trim());
                DatagridTerreno.DataSource = null;
                DatagridTerreno.DataSource = lista;

                configurarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cragra los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void BtnGuardarTerreno_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                if (!EsEdicion)
                {
                    decimal areaConvertida = Convert.ToDecimal(txtareat.Text.Trim());
                    bool estadoConvertido = true;

                    decimal? latitudConvertida = string.IsNullOrWhiteSpace(txtlatitu.Text) ? (decimal?)null : Convert.ToDecimal(txtlatitu.Text.Trim());
                    decimal? longitudConvertida = string.IsNullOrWhiteSpace(txtlongi.Text) ? (decimal?)null : Convert.ToDecimal(txtlongi.Text.Trim());
                    TerrenoEntity nuevo = new TerrenoEntity
                        (
                         txtterrenp.Text.Trim(),
                areaConvertida,
              estadoConvertido,
                txtubica.Text.Trim(),
                latitudConvertida,
                longitudConvertida
                        );
                    btnEditarterreno.Enabled = false;
                    await _terrenoBLL.agregart(nuevo);

                    MessageBox.Show("Terreno agregado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LImpiarFormulario();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            await CargarListadoAsincrono();
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

        private async void FrmTerreno_Load(object sender, EventArgs e)
        {
            await CargarListadoAsincrono();
            CargarEstados();
        }

        private async void txtbuscarTerreno_TextChanged(object sender, EventArgs e)
        {
            await CargarListadoAsincrono();
        }

        private void LImpiarFormulario()
        {
            txtterrenp.Clear();
            txtareat.Clear();
            if (conEstado.Items.Count > 0) conEstado.SelectedIndex = 0;
            txtubica.Clear();
            txtlatitu.Clear();
            txtlongi.Clear();

            BtnGuardarTerreno.Enabled = true;
            btnEditarterreno.Enabled = true;
            txtterrenp.Focus();

        }
        private bool ValidarCampos()
        {
            Iconerror.Clear();
            bool valido = true;

            if (!ValidarHelper.Requerido(txtterrenp, Iconerror, "Debe ingresar el Nombre del Empleado."))
                valido = false;
            if (!ValidarHelper.Requerido(txtareat, Iconerror, "Debe ingresar el número de teléfono."))
                valido = false;

            if (conEstado.SelectedValue == null)
            {
                Iconerror.SetError(conEstado, "Debe seleccionar el estado.");
                valido = false;
            }
            if (!ValidarHelper.Requerido(txtubica, Iconerror, "Debe ingresar la contraseña."))
                valido = false;
            /* (!ValidarHelper.Requerido(txtlatitu, Iconerror, "Debe ingresar la contraseña."))
                 valido = false;
             if (!ValidarHelper.Requerido(txtlongi, Iconerror, "Debe ingresar la contraseña."))
                 valido = false;*/

            return valido;
        }

        private async void btnEditarterreno_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idTerrenoSeleccionado == null || _idTerrenoSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor, seleccione un terreno de la tabla para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtterrenp.Text))

                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtareat.Text.Trim(), out decimal areaConvertida))
                {
                    MessageBox.Show("El área debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal? latitudConvertida = string.IsNullOrWhiteSpace(txtlatitu.Text) ? (decimal?)null : Convert.ToDecimal(txtlatitu.Text);
                decimal? longitudConvertida = string.IsNullOrWhiteSpace(txtlongi.Text) ? (decimal?)null : Convert.ToDecimal(txtlongi.Text);

                TerrenoEntity terrenoModificado = new TerrenoEntity();
                terrenoModificado.asignarId(_idTerrenoSeleccionado.Value);
                terrenoModificado.cambiarnombre(txtterrenp.Text.Trim());
                terrenoModificado.cambiararea(areaConvertida);
                terrenoModificado.Latitud = latitudConvertida;
                terrenoModificado.Longitud = longitudConvertida;
                if (conEstado.Items.Count > 0) conEstado.SelectedIndex = 0;

                await _terrenoBLL.Actualizar(terrenoModificado); ;

                MessageBox.Show("Terreno actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LImpiarFormulario();
                _idTerrenoSeleccionado = null;
                BtnGuardarTerreno.Enabled = true;

                await CargarListadoAsincrono();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
