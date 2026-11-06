using GMap.NET.WindowsForms;
using HelpDagrotech.UI.Formularios.BaseDatos;
using HelpDagrotech.UI.Formularios.Hijos;
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
    public partial class FrmAgroT : Form
    {
        //para conocer cual es el formulario que esta ativo 
        private Form? formularioActivo;
        private bool _cerrarsesion = false;
        private AgrotechBll _dalba = new AgrotechBll { };



        public FrmAgroT()
        {
            InitializeComponent();
        }


        #region Sibedar
        private void IconButton1_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }
        #endregion

        #region Métodos
        public void CerrarSesion()
        {
            _cerrarsesion = true;
            DialogResult = DialogResult.Retry;
            Close();
        }
        #endregion

        private void FrmAgroT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cerrarsesion)
                return;

            DialogResult respuesta = MessageBox.Show("¿Seguro  que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }

        private void IconInicio_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivoI(), panelContenedo, ref formularioActivo, iconInicio);
        }

        private void iconMiterreno_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmTerreno(), panelContenedo, ref formularioActivo, iconMiterreno);
        }

        private void iconCultivo_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivo(), panelContenedo, ref formularioActivo, iconCultivo);
        }

        private void iconMaterial_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmMaterial(), panelContenedo, ref formularioActivo, iconMaterial);
        }

        private void iconEmpleado_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmEmpelado(), panelContenedo, ref formularioActivo, iconEmpleado);
        }

        private async void FrmAgroT_Load(object sender, EventArgs e)
        {
            try
            {
                var stats = await _dalba.ObtenerEstadisticasGeneralesAsync();

                label14.Text = $"{stats.TerrenosActivos}/20";
                label15.Text = $"{stats.EmpleadosActivos}/15";
                label16.Text = $"{stats.CosechasListas}/10";
                label17.Text = $"${stats.GananciasTotales:N2}";
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
                //  CargarDatosDashboard();
            }));
        }

        private void CargarDatosDashboard()
        {
            // --- 1. CONFIGURAR Y CARGAR: MOVIMIENTO RECIENTE ---
            if (Dvgmovreciat.Columns.Count == 0)
            {
                Dvgmovreciat.Columns.Add("FechaHora", "Fecha / Hora");
                Dvgmovreciat.Columns.Add("Accion", "Descripción del Movimiento");
            }
            Dvgmovreciat.Rows.Clear();
            Dvgmovreciat.Rows.Add("10:15 AM", "Cosecha registrada en Parcela #3");
            Dvgmovreciat.Rows.Add("08:30 AM", "Riego automático iniciado en Parcela #1");
            Dvgmovreciat.Rows.Add("Ayer", "Mantenimiento preventivo en bodegas");

            // --- 2. CONFIGURAR Y CARGAR: ALERTA RECIENTE ---
            if (DvgAletreciat.Columns.Count == 0)
            {
                DvgAletreciat.Columns.Add("Nivel", "Estado");
                DvgAletreciat.Columns.Add("Mensaje", "Descripción de Alerta");
            }
            DvgAletreciat.Rows.Clear();
            DvgAletreciat.Rows.Add("🔔 Media", "Revisar niveles de abono en Lote #2");

            // --- 3. CONFIGURAR Y CARGAR: INSUMO CRÍTICO ---
            if (DvgInsureciat.Columns.Count == 0)
            {
                DvgInsureciat.Columns.Add("Insumo", "Material / Insumo");
                DvgInsureciat.Columns.Add("Stock", "Cantidad Restante");
            }
            DvgInsureciat.Rows.Clear();
            DvgInsureciat.Rows.Add("Urea", "2 sacos (Crítico)");
            DvgInsureciat.Rows.Add("Fertilizante NPK", "5 kg (Bajo)");
        }



        private void label15_Click(object sender, EventArgs e)
        {

        }


        private void iconMiterreno_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmTerreno(), panelContenedo, ref formularioActivo, iconMiterreno);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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




        private void iconEmpleado_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmEmpelado(), panelContenedo, ref formularioActivo, iconEmpleado);
        }

        private void iconCultivo_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivo(), panelContenedo, ref formularioActivo, iconCultivo);
        }

        private void iconMaterial_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmMaterial(), panelContenedo, ref formularioActivo, iconMaterial);



        }

        private void iconInicio_Click_1(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmCultivoI(), panelContenedo, ref formularioActivo, iconInicio);
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }

        private void FrmAgroT_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, AgroT.Width - 1, AgroT.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                AgroT.Region = new Region(path);
            }
        }

        private void iconSalidam_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmSalidaMat(), panelContenedo, ref formularioActivo, iconSalidam);
        }

        private void iconDecodific_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmDecodificacion(), panelContenedo, ref formularioActivo, iconDecodific);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panterreno.Width - 1, panterreno.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panterreno.Region = new Region(path);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelempleados.Width - 1, panelempleados.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelempleados.Region = new Region(path);
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panel13.Width - 1, panel13.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panel13.Region = new Region(path);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelganancias3.Width - 1, panelganancias3.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelganancias3.Region = new Region(path);
            }
        }

        private void iconDecodific_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconEmpleado.Width - 1, iconEmpleado.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconEmpleado.Region = new Region(path);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconDecodific.Width - 1, iconDecodific.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconDecodific.Region = new Region(path);

            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconCultivo.Width - 1, iconCultivo.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconCultivo.Region = new Region(path);

            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconInicio.Width - 1, iconInicio.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconInicio.Region = new Region(path);

            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconMaterial.Width - 1, iconMaterial.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconMaterial.Region = new Region(path);

            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconMiterreno.Width - 1, iconMiterreno.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconMiterreno.Region = new Region(path);

            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconSalidam.Width - 1, iconSalidam.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconSalidam.Region = new Region(path);

            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, iconreprot.Width - 1, iconreprot.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                iconreprot.Region = new Region(path);

            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, bttSalir.Width - 1, bttSalir.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                bttSalir.Region = new Region(path);

            }

           
        }




        private void iconreprot_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmReporte(), panelContenedo, ref formularioActivo, iconreprot);
        }

        private async void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void Dvgmovreciat_BorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void Dvgmovreciat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

 