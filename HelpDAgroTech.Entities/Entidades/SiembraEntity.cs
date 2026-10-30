using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class SiembraEntity
    {
      
            public int Id_Siembra { get; set; }
            public int Id_Terreno { get; set; }
            public int Id_Cultivo { get; set; }
            public string Duracion { get; set; } = string.Empty;
            public DateTime Fecha { get; set; }

            // Propiedades opcionales por si haces JOIN en tu procedimiento de listar para mostrar nombres en el grid
            public string Nombre_T { get; set; } = string.Empty;
            public string Nombre { get; set; } = string.Empty;
        
    }
}
