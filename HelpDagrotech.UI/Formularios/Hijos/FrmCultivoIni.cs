using GMap.NET;
using GMap.NET.WindowsForms;
using HelpDagrotech.UI.Helpers;
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
    public partial class FrmCultivoI : Form
    {
        private AgrotechBll _dalba = new AgrotechBll { };

        public FrmCultivoI()
        {
            InitializeComponent();

        }

        //  private double latOriginal = 11.539626;
        // private double lngOriginal = -85.608108;
        //   private GMapOverlay capaLotes;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        private void FrmMapa_Load(object sender, EventArgs e)
        {

        }

        private void RedondearTarjetasModulos()
        {
            // Ajusta los nombres 'panelTerrenos', 'panelEmpleados', etc., 
            // por los nombres reales que tengan esos paneles en tu diseñador
            RedonderControlesHelper.RedondearControl(panelTerreno, 15);
            RedonderControlesHelper.RedondearControl(panelEmpelado12, 15);
            RedonderControlesHelper.RedondearControl(panelganancia9, 15);
            RedonderControlesHelper.RedondearControl(panelcosecha6, 15);
        }
        private async void FrmCultivoIni_Load(object sender, EventArgs e)
        {

            try
            {
                var stats = await _dalba.ObtenerEstadisticasGeneralesAsync();

                label14.Text = $"{stats.TerrenosActivos}/20";
                label16.Text = $"{stats.EmpleadosActivos}/15";
                label15.Text = $"{stats.CosechasListas}/10";
                label18.Text = $"${stats.GananciasTotales:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detallado: " + ex.ToString(), "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                CargarDatosDashboard();
            }));
        }

        // Evento que se ejecuta al hacer clic en cualquier parcela para hacer zoom en ella
        private void GMapControl1_OnPolygonClick(GMapPolygon polygon, MouseEventArgs e)
        {
            if (polygon.Points.Count > 0)
            {
                // Tomamos el primer punto de la parcela seleccionada para centrar la vista
                double latCentro = polygon.Points[0].Lat;
                double lngCentro = polygon.Points[0].Lng;

                // Habilitar temporalmente el zoom de acercamiento máximo para detallar la parcela
                gMapControl1.MinZoom = 19;
                gMapControl1.MaxZoom = 19;
                gMapControl1.Zoom = 19;
                gMapControl1.Position = new PointLatLng(latCentro, lngCentro);
                gMapControl1.Refresh();
            }
        }

        // Método para regresar a la vista general de la finca (puedes conectarlo a un botón "Ver Todo")
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            gMapControl1.MinZoom = 16;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 16;
            //    gMapControl1.Position = new PointLatLng(GetLatOriginal(), lngOriginal);
            gMapControl1.Refresh();

        }


        private void CargarDatosDashboard()
        {
            // --- 1. CONFIGURAR Y CARGAR: MOVIMIENTO RECIENTE ---
            if (dvgmovimientore.Columns.Count == 0)
            {
                dvgmovimientore.Columns.Add("FechaHora", "Fecha / Hora");
                dvgmovimientore.Columns.Add("Accion", "Descripción del Movimiento");
            }
            dvgmovimientore.Rows.Clear();
            dvgmovimientore.Rows.Add("10:15 AM", "Cosecha registrada en Parcela #3");
            dvgmovimientore.Rows.Add("08:30 AM", "Riego automático iniciado en Parcela #1");
            dvgmovimientore.Rows.Add("Ayer", "Mantenimiento preventivo en bodegas");

            // --- 2. CONFIGURAR Y CARGAR: ALERTA RECIENTE ---
            if (dvglaet.Columns.Count == 0)
            {
                dvglaet.Columns.Add("Nivel", "Estado");
                dvglaet.Columns.Add("Mensaje", "Descripción de Alerta");
            }
            dvglaet.Rows.Clear();
            dvglaet.Rows.Add("🔔 Media", "Revisar niveles de abono en Lote #2");

            // --- 3. CONFIGURAR Y CARGAR: INSUMO CRÍTICO ---
            if (dvginsumoc.Columns.Count == 0)
            {
                dvginsumoc.Columns.Add("Insumo", "Material / Insumo");
                dvginsumoc.Columns.Add("Stock", "Cantidad Restante");
            }
            dvginsumoc.Rows.Clear();
            dvginsumoc.Rows.Add("Urea", "2 sacos (Crítico)");
            dvginsumoc.Rows.Add("Fertilizante NPK", "5 kg (Bajo)");
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelEmpelado12.Width - 1, panelEmpelado12.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelEmpelado12.Region = new Region(path);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelTerreno.Width - 1, panelTerreno.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelTerreno.Region = new Region(path);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelcosecha6.Width - 1, panelcosecha6.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelcosecha6.Region = new Region(path);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelganancia9.Width - 1, panelganancia9.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelganancia9.Region = new Region(path);
            }
        }

        private void FrmCultivoIni_Shown(object sender, EventArgs e)
        {
            RedondearTarjetasModulos();
        }
        private void dvgmovimientore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelEmpelado12_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void FrmCultivoIni_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

 
    
 
    
    
  
    

