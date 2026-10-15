using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Dal.Common
{
    public class SqlError
    {
        public static Exception TraducirError(SqlException ex)
        {
            return ex.Number switch
            {
                // ==========================
                // EMPLEADOS (Rango 51000)
                // ==========================
                51001 => new Exception("La cédula del empleado ya está registrada."),
                51002 => new Exception("El empleado no existe."),
                51003 => new Exception("El empleado está inactivo."),

                // ==========================
                // CATEGORÍAS (Rango 52000)
                // ==========================
                52001 => new Exception("La categoría ya existe."),
                52002 => new Exception("La categoría no existe."),

                // ==========================
                // MATERIALES / INSUMOS (Rango 53000)
                // ==========================
                53001 => new Exception("El material ya se encuentra registrado."),
                53002 => new Exception("El material no existe."),
                53003 => new Exception("El stock del material es insuficiente."),

                // ==========================
              
                // ==========================
                54001 => new Exception("El terreno ya existe."),
                54002 => new Exception("El terreno no existe."),

                // ==========================
                // CULTIVOS (Rango 55000)
                // ==========================
                55001 => new Exception("El cultivo ya está registrado."),
                55002 => new Exception("El cultivo no existe."),

                // ==========================
                // ERROR GENERAL / INESPERADO
                // ==========================
                _ => new Exception("Ocurrió un error inesperado en la base de datos.", ex)
            };
        }
    }
}
