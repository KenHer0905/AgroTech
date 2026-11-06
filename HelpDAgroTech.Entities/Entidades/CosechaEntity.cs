using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class CosechaEntity
    {
        // Propiedades mapeadas a las columnas de la base de datos
        public int Id_cosecha { get; set; }
        public int Id_Siembra { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad_Medida { get; set; }
        public DateTime Fecha { get; set; }

        
        public string Nombre { get; set; }

      
        public CosechaEntity()
        {
            Id_cosecha = 0;
            Id_Siembra = 0;
            Cantidad = 0.0m;
            Unidad_Medida = "Quintales"; // Valor por defecto según tu esquema SQL
            Fecha = DateTime.Now;
        }

     
        public CosechaEntity(int idCosecha, int idSiembra, decimal cantidad, string unidadMedida, DateTime fecha)
        {
            Id_cosecha = idCosecha;
            Id_Siembra = idSiembra;
            Cantidad = cantidad;
            Unidad_Medida = unidadMedida;
            Fecha = fecha;
        }

    
        public CosechaEntity(int idSiembra, decimal cantidad, string unidadMedida, DateTime fecha)
        {
            Id_Siembra = idSiembra;
            Cantidad = cantidad;
            Unidad_Medida = unidadMedida;
            Fecha = fecha;
        }
    }
}
