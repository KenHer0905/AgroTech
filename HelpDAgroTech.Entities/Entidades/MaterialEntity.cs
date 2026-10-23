using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class MaterialEntity
    {
        public int Id_Material { get; set; }
        public string Nombre_material { get; set; } = string.Empty;
        public int Id_Categoria { get; set; }
        public string Unidad_material { get; set; } = string.Empty;

       
        public decimal Stock { get; set; }
        public decimal Stock_minimo { get; set; }
        public decimal Precio { get; set; }
    }
}
