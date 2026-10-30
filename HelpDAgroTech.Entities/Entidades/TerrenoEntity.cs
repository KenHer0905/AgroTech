using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class TerrenoEntity
    {
        public int Id_Terreno { get; set; }
        public string Nombre_T { get; set; } = string.Empty;
        public decimal Area { get; set; }
        public bool Estado { get; set; } 
        public string Ubicacion { get; set; } = string.Empty;
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
    }


}
