using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HelpDAgroTech.Entities.Entidades
{
    public class EmpleadoEntity
    {
        public int Id_empleado { get; private set; }
        public string Nombre_empleado { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public DateTime Fecha_nacimiento { get; set; }
        public string Contrasena { get; set; } = string.Empty;
        public int Id_Rol { get; set; }
        public string Rol { get; set; } = string.Empty;
        public bool Estado { get; private set; } = true;
        public string EstadoTexto => Estado ? "Activo": "Inactivo";

        #region Contructores

        
        public EmpleadoEntity() { }//Permite recontruir la inf de la class cuando se obtiene la inf de la DB.  estos dsp parametros se les conoce sobrecarga

        public EmpleadoEntity(string nombre_empleado, string telefono, string cedula, DateTime fecha_nacimiento, int id_rol, string contrasena)
        {
            CambiarNombreEmpleado(nombre_empleado);
            CambiarTelefono(telefono);
            CambiarCedula(cedula);
            CambiarFechaNacimiento (fecha_nacimiento);
            CambiarIdrol(id_rol);
            Estado = true;
            CambiarContrasena(contrasena);
          

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


        public void CambiarRol(string nombreRol) => Rol = nombreRol;

        public void CambiarEstado(bool estado)
        {
            Estado = estado;
        }

      
        public void CambiarContrasena(string contrasenaHash)
        {

            Contrasena = contrasenaHash.Trim();
        }
        public void CambiarFechaNacimiento(DateTime fecha_nacimiento)
        {
            if (fecha_nacimiento > DateTime.Now)
                throw new Exception("La fecha de nacimiento no puede ser mayor a la actual.");

            Fecha_nacimiento = fecha_nacimiento;
        }



        #endregion
    }
}

