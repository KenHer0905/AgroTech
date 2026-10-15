using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelpDagrotech.UI.Helpers
{
    public static class ValidarHelper
    {
        /// <summary>
        /// Valida que un TextBox no esté vacío
        /// </summary>
        public static bool Requerido(TextBox textBox, ErrorProvider errorProvider, string mensaje)//sobrr las validaciones del texto
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }

            errorProvider.SetError(textBox, mensaje);
            textBox.Focus();
            return false;
        }


        /// <summary>
        /// Valida que un ComboBox tenga un elemento seleccionado
        /// </summary>
        public static bool Requerido(ComboBox comboBox, ErrorProvider errorProvider, string mensaje)
        {
            if (comboBox.SelectedIndex >= 0)
            {
                errorProvider.SetError(comboBox, "");
                return true;
            }

            errorProvider.SetError(comboBox, mensaje);
            comboBox.Focus();
            return false;
        }


        /// <summary>
        /// Valida que un email se correcto
        /// </summary>
        public static bool Cedula(TextBox textBox, ErrorProvider errorProvider)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(textBox.Text, patron))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }

            errorProvider.SetError(textBox, "Ingrese un correo válido.");
            textBox.Focus();
            return false;
        }

    }
}
