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
            public string NombreTerreno { get; set; }
            public int Id_Cultivo { get; set; }
            public string NombreCultivo { get; set; }
            public string Duracion { get; set; } = string.Empty;
            public DateTime Fecha { get; set; }


        public SiembraEntity() { }

        public void AsignarId(int id)
        {
            Id_Siembra = id;
        }

    }
}