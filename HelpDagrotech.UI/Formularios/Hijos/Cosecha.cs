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

namespace HelpDagrotech.UI.Formularios.Hijos
{
    public partial class Cosecha : Form
    {
        private CosechaDal _cosechaDal = new CosechaDal();

        public Cosecha()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private async void Cosecha_Load(object sender, EventArgs e)
        {
            
            FormatearGridCosecha();

          
            txtfechainicio.Value = new DateTime(DateTime.Now.Year, 1, 1);
            txtfechafinal.Value = DateTime.Now;

            
            await MostrarCosechaAsync();
        }

        private void FormatearGridCosecha()
        {
            dvgCosecha.EnableHeadersVisualStyles = false;
            dvgCosecha.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 63, 32); // #1E3F20
            dvgCosecha.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgCosecha.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dvgCosecha.ColumnHeadersHeight = 35;

            dvgCosecha.RowsDefaultCellStyle.BackColor = Color.White;
            dvgCosecha.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 247, 246);
            dvgCosecha.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dvgCosecha.DefaultCellStyle.SelectionForeColor = Color.White;

            dvgCosecha.BackgroundColor = Color.FromArgb(244, 247, 246);
            dvgCosecha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCosecha.RowHeadersVisible = false;
            dvgCosecha.ReadOnly = true;
            dvgCosecha.AllowUserToAddRows = false;
        }

        private void AjustarNombresColumnas()
        {
            if (dvgCosecha.Columns.Contains("Id_cosecha"))
                dvgCosecha.Columns["Id_cosecha"].HeaderText = "N° Cosecha";

            if (dvgCosecha.Columns.Contains("Id_Siembra"))
                dvgCosecha.Columns["Id_Siembra"].HeaderText = "N° Siembra";

            if (dvgCosecha.Columns.Contains("NombreCultivo"))
                dvgCosecha.Columns["NombreCultivo"].HeaderText = "Cultivo";

            if (dvgCosecha.Columns.Contains("Cantidad"))
            {
                dvgCosecha.Columns["Cantidad"].HeaderText = "Cantidad";
                dvgCosecha.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            }

            if (dvgCosecha.Columns.Contains("unidad_medida") || dvgCosecha.Columns.Contains("Unidad_Medida"))
            {
                string colName = dvgCosecha.Columns.Contains("unidad_medida") ? "unidad_medida" : "Unidad_Medida";
                dvgCosecha.Columns[colName].HeaderText = "Unidad";
            }

            if (dvgCosecha.Columns.Contains("fecha") || dvgCosecha.Columns.Contains("Fecha"))
            {
                string colName = dvgCosecha.Columns.Contains("fecha") ? "fecha" : "Fecha";
                dvgCosecha.Columns[colName].HeaderText = "Fecha Cosecha";
                dvgCosecha.Columns[colName].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private async Task MostrarCosechaAsync()
        {
            try
            {
                List<CosechaEntity> lista = await _cosechaDal.ObtenerCosechasAsync();

                dvgCosecha.DataSource = null;
                dvgCosecha.DataSource = lista;

                AjustarNombresColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void txtCosecha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textoBusqueda = txtCosecha.Text.Trim();
                var listaCompleta = await _cosechaDal.ObtenerCosechasAsync();

                var listaFiltrada = listaCompleta.Where(c =>
                    
                    (!string.IsNullOrEmpty(c.Unidad_Medida) && c.Unidad_Medida.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    c.Id_cosecha.ToString().Contains(textoBusqueda)
                ).ToList();

                dvgCosecha.DataSource = null;
                dvgCosecha.DataSource = listaFiltrada;
                AjustarNombresColumnas();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error filtrando: " + ex.Message);
            }
        }

        private async void txtfechainicio_ValueChanged(object sender, EventArgs e)
        {
            await FiltrarPorRangoFechas();
        }

        private async void txtfechafinal_ValueChanged(object sender, EventArgs e)
        {
            await FiltrarPorRangoFechas();
        }

        private async Task FiltrarPorRangoFechas()
        {
            try
            {
                DateTime inicio = txtfechainicio.Value.Date;
                DateTime fin = txtfechafinal.Value.Date;

                if (inicio > fin)
                    return; 
                var listaFiltrada = await _cosechaDal.FiltrarCosechasPorFechaAsync(inicio, fin);

                dvgCosecha.DataSource = null;
                dvgCosecha.DataSource = listaFiltrada;
                AjustarNombresColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fecha: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

