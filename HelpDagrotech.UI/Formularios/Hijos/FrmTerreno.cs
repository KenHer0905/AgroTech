using GMap.NET.WindowsForms;
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
    public partial class FrmTerreno : Form
    {
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

        }
    }
}
