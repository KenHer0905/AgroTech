using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HelpDAgroTech.Entities.Entidades
{
    public class UsuarioEntityA
    {
        public int Id_empleado { get; private set; }
        public string Nombre_empleado { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public bool Estado { get; set; } = true;
        public string Cedula { get; set; } = string.Empty;
        public DateTime Fecha_nacimiento { get; set; }
        public string Contrasena { get; set; } = string.Empty;
        public int Id_Rol { get; set; }
        public string Rol { get; set; } = string.Empty;

        #region Contructores
        public UsuarioEntityA() { }//Permite recontruir la inf de la class cuando se obtiene la inf de la DB.  estos dsp parametros se les conoce sobrecarga

        public UsuarioEntityA(string nombre_empleado, int id_rol, string cedula, string telefono) // permitira trabajar cuando se desee agregar un nuevo registro, esto se da por lo que se trabaja con encapsulamiento
        {
            CambiarNombreEmpleado(nombre_empleado);
            CambiarIdrol(id_rol);
            CambiarCedula(cedula);
            CambiarTelefono(telefono);
            Estado = true;
        }

        #endregion
        #region Metodos
        public void AsignarId(int id)
        {
            Id_empleado = id;
        }
        public void CambiarNombreEmpleado(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Especificar el nombre empleado del empleado");


            Nombre_empleado = nombre.Trim();
        }

        public void CambiarTelefono(string telef)
        {
            if (string.IsNullOrWhiteSpace(telef))
                throw new Exception("Especificar el telefono del empleado");


            Telefono = telef.Trim();
        }

        public void CambiarCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                throw new Exception("Especificar cedula del empleado");


            Cedula = cedula.Trim();
        }

        public void CambiarIdrol(int idRol)
        {
            if (idRol<=0)
                throw new Exception("Deber seleccionar un IdRol");


            Id_Rol = idRol;
        }

        #endregion
    }
}

