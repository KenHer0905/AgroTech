using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDagrotech.UI.Seguridad
{
    public static class UsuarioSesion
    {


        public static int Id_empleado { get; set; } = 1;
        public static string Nombre_empleado { get; set; } = "Maria Gonzales";
        public static int Id_Rol { get; set; } = 1;

        public static string Rol { get; set; } = "Admin";


        /// <summary>
        /// Registrar sesión
        /// </summary>
        public static void IniciarSesion(EmpleadoEntity Empleado)
        {
            Id_empleado = Empleado.Id_empleado;
            Nombre_empleado = Empleado.Nombre_empleado;
            Id_Rol = Empleado.Id_Rol;
            Rol = Empleado.Rol = "Admin";
        }


        /// <summary>
        /// Cerrar sesión
        /// </summary>
        public static void CerrarSesion()
        {
            Id_empleado = 0;
            Nombre_empleado = string.Empty;
            Id_Rol = 0;
            Rol = string.Empty;
        }
    }
}