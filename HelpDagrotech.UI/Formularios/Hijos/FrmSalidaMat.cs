using HelpDAgroTech.Bll;
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

namespace HelpDagrotech.UI.Formularios.Hijos
{
    public partial class FrmSalidaMat : Form
    {
        public FrmSalidaMat()
        {
            InitializeComponent();
        }

        private void FrmSalidaMat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panelsalidamat.Width - 1, panelsalidamat.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panelsalidamat.Region = new Region(path);
            }
        }

        //  private async void txtbuscarSalidaMat_TextChanged(object sender, EventArgs e)
        // {
        //
        // \await CargarListadoAsincrono();
        // }




        private void dvgsalidamaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dvgsalidamaterial.Rows[e.RowIndex];


            // Cargar la fecha en el DateTimePicker
            if (fila.Cells["Fecha_Movimiento"].Value != DBNull.Value)
            {
                txtFechaSalida.Value = Convert.ToDateTime(fila.Cells["Fecha_Movimiento"].Value);
            }

            // Seleccionar el Empleado en el ComboBox (Llave Foránea)
            if (fila.Cells["Id_empleado"].Value != null && fila.Cells["Id_empleado"].Value != DBNull.Value)
            {
                Cboxempleadosalida.SelectedValue = Convert.ToInt32(fila.Cells["Id_empleado"].Value);
            }

            // Seleccionar el Terreno en el ComboBox (Manejando posibles valores nulos)
            if (fila.Cells["Id_Terreno"].Value != null && fila.Cells["Id_Terreno"].Value != DBNull.Value)
            {
                Cboxterrenosalida.SelectedValue = Convert.ToInt32(fila.Cells["Id_Terreno"].Value);
            }
            else
            {
                Cboxterrenosalida.SelectedIndex = -1; // Deja limpio si no tiene terreno asignado
            }

            // Cargar el Tipo de Movimiento (Ej. "Salida")
            CboxTiposalida.Text = fila.Cells["Tipo_Movimiento"].Value?.ToString();

            // Bloquear campos de cabecera si se está consultando un registro existente
            txtFechaSalida.Enabled = false;
            Cboxempleadosalida.Enabled = false;
            Cboxterrenosalida.Enabled = false;
            CboxTiposalida.Enabled = false;

            // Desactivar botón de guardado para evitar duplicados al hacer clic en una fila ya registrada
            bttguardarsalida.Enabled = false;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el contorno redondeado del panel de manera limpia
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radio = 20;
                Rectangle rect = new Rectangle(0, 0, panel6.Width - 1, panel6.Height - 1);

                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                panel6.Region = new Region(path);
            }
        }
    }
}
