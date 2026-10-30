using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class DecodificacionEntity
    {
        public int Id_Material_Cult { get; set; }
        public int Id_Material { get; set; }
        public int Id_Cultivo { get; set; }
        public decimal Cantidad_Area { get; set; }
        public string Etapa_Aplicacion { get; set; } = string.Empty;

        // si acaso hacemos JOIN
        public string Nombre_Material { get; set; } = string.Empty;
        public string Nombre_Cultivo { get; set; } = string.Empty;
    }
}
