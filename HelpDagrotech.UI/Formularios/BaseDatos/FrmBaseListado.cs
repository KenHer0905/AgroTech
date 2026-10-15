using HelpDagrotech.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HelpDagrotech.UI.Formularios.BaseDatos
{
    public partial class FrmBaseListado : Form
    {


        protected int PaginaActual = 1;
        protected int TamPagina = 10;
        protected int TotalPaginas = 0;
        protected int TotalRegistro = 0;

        public FrmBaseListado()
        {
            InitializeComponent();

        }
        #region Metodos  Virtuales
        protected virtual bool MostrarBotonPrincipal => true;
        protected virtual bool MostrarBotonSecundario => true;
        protected virtual bool MostrarBotonTerceario => true;



        protected virtual Task MostrarDatosAsync(int pagina, int tampagina, string? buscar = null)
        {

            return Task.CompletedTask;
        }
        protected void ActualizarBotonPaginacion()
        {
            //Sin registro
            if (TotalRegistro <= 0)
            {
                buttonprimero.Enabled = false;
                buttosegundo.Enabled = false;
                buttondespues.Enabled = false;
                buttosiguiente.Enabled = false;

                return;
            }
            // primera pagina
            buttonprimero.Enabled = PaginaActual < 1;
            buttondespues.Enabled = PaginaActual < 1;

            // Uttima pagina
            buttosegundo.Enabled = PaginaActual < TotalPaginas;
            buttosiguiente.Enabled = PaginaActual < TotalPaginas;

        }
        protected void ActualizarPaginas()
        {
            if (TotalRegistro == 0)
            {
                lbltotalpaginas.Text = "Total de registros 0";
                lblpaginas.Text = "Paginas 0 de 0";

                ActualizarBotonPaginacion();
                return;
            }
            lbltotalpaginas.Text = $"Total Registro: {TotalRegistro}";
            lblpaginas.Text = $" Paginas{PaginaActual} de {TotalPaginas}";

            ActualizarBotonPaginacion();
            return;
        }

        protected virtual Form? CrearFormularioAccionPrincipal()
        {
            return null;
        }
        protected virtual Form? CrearFormularioAccionSecundaria(int value)
        {
            return null;
        }
        protected virtual int? ObtenerIdSeleccionado()
        {
            return null;
        }

        protected virtual Task DesactivarAsync()
        {
            return Task.CompletedTask;
        }
        protected virtual void FormatearCeldad(DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name != "Estados")
                return;
            GridColorHelper.FormatearActivoInactivo(e);
        }
        protected void AjustarColumnas(params string[] Columnas)
        {
            foreach (string Columnas0 in Columnas)
            {
                if (dgvListado.Columns.Contains(Columnas0))
                    continue;
                dgvListado.Columns[Columnas0]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        #endregion
        #region Perzonalizar Formulario
        protected void MostrarEstadoActivo(bool tienesDatos)
        {
            dgvListado.Visible = tienesDatos;
            icnpinbuscarregistro.Visible = !tienesDatos;
        }
        #endregion

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private async void FrmBaseListado_Load(object sender, EventArgs e)
        {
            buttonNuevo.Visible = MostrarBotonPrincipal;
            buttoneditar.Visible = MostrarBotonSecundario;
            buttonestados.Visible = MostrarBotonTerceario;

            GridColorHelper.Personalizar(dgvListado);
            await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);
        }

        private async void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            PaginaActual = 1;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);
        }

        private void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatearCeldad(e);
        }

        private void FrmBaseListado_Shown(object sender, EventArgs e)
        {
            RedonderControlesHelper.RedondearControl(panelContenido, 20);
            RedonderControlesHelper.RedondearControl(Panelpaginas, 20);


            RedonderControlesHelper.RedondearControl(buttoneditar, 12);
            RedonderControlesHelper.RedondearControl(buttonestados, 12);
            RedonderControlesHelper.RedondearControl(buttonNuevo, 12);

            RedonderControlesHelper.RedondearControl(dgvListado, 15);
            RedonderControlesHelper.RedondearControl(icnpinbuscarregistro, 15);
            RedonderControlesHelper.RedondearControl(panelbuscador, 15);
        }

        private async void buttonprimero_Click(object sender, EventArgs e)
        {
            PaginaActual = 1;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);


        }

        private async void buttondespues_Click(object sender, EventArgs e)
        {
            if (PaginaActual <= 1)
                return;

            PaginaActual--;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);

        }

        private async void buttosiguiente_Click(object sender, EventArgs e)
        {
            if (PaginaActual <= TotalPaginas)
                return;

            PaginaActual++;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);
        }

        private async void buttosegundo_Click(object sender, EventArgs e)
        {
            PaginaActual = TotalPaginas;

            await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);
        }

        private async void buttonNuevo_Click(object sender, EventArgs e)
        {
            Form? frm = CrearFormularioAccionPrincipal();

            if (frm == null)
                return;

            Form frmPrincipal = this.FindForm()!;

            using (FrmOverlay overlay = new FrmOverlay(frmPrincipal))
            {
                overlay.Show();

                // Colocar el overlay encima del principal
                overlay.BringToFront();

                // Centrar el modal respecto al principal
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                    await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);
            }

        }

        private async void buttoneditar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerIdSeleccionado();

            if (id is null)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form? frm = CrearFormularioAccionSecundaria(id.Value);

            if (frm == null)
                return;

            using (FrmOverlay overlay = new FrmOverlay(this.FindForm()!))
            {
                overlay.Show();

                if (frm.ShowDialog() == DialogResult.OK)
                    await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);
            }
        }

        private async void buttonestados_Click(object sender, EventArgs e)
        {
            await DesactivarAsync();
        }
    }
}
