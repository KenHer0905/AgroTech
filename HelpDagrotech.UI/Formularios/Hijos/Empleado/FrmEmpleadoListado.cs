using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HelpDagrotech.UI.Formularios.BaseDatos;

namespace HelpDagrotech.UI.Formularios.Hijos.Empleado
{
    public partial class FrmEmpleadoListado : FrmBaseListado
    {
        private readonly Empleado _empleadoBll = new();

        public FrmEmpleadoListado()
        {
            InitializeComponent();
        }

        // 1. Sobreescribir el método para mostrar los datos en el DataGridView
        protected override async Task MostrarDatosAsync(int pagina, int tampagina, string? buscar)
        {
            try
            {
                var resultado = await _empleadoBll.MostrarAsync(pagina, tampagina, buscar);

                DgbListado.DataSource = resultado.Items;

                PaginaActual = resultado.PaginaActual;
                TotalPaginas = resultado.TotalPaginas;
                TotalRegistros = resultado.TotalRegistros;

                ActualizarPaginacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Sobreescritura para enlazar el formulario de Crear (Nuevo)
        protected override Form? CrearFormularioAccionPrincipal()
        {
            return new FrmEmpleadoRegistro();
        }

        // 3. Sobreescritura para enlazar el formulario de Editar
        protected override Form? CrearFormularioAccionSecundaria(int id)
        {
            return new FrmEmpleadoRegistro(id);
        }

        // 4. Sobreescritura para Activar / Desactivar (Estado)
        protected override async Task DesactivarAsync()
        {
            int? id = ObtenerIdSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool estadoActual = Convert.ToBoolean(dgvListado.CurrentRow.Cells["Estado"].Value);
            string accion = estadoActual ? "desactivar" : "activar";

            var respuesta = MessageBox.Show($"¿Desea {accion} este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await _empleadoBll.CambiarEstadoAsync(id.Value, !estadoActual);
                await MostrarDatosAsync(PaginaActual, TamPagina, txtbuscador.Text);
            }
        }
    }
}
