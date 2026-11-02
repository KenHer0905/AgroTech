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
        public bool Estado { get; set; } = true;
        public string Ubicacion { get; set; } = string.Empty;
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string EstadoT => Estado ? "Activo" : "Inactivo";

        public TerrenoEntity() { }

        public TerrenoEntity(string mombre, decimal area, bool estado, string ubicacion, decimal? latitud = null, decimal? longitud = null)
        {
            cambiarnombre(mombre);
            cambiararea(area);
            cambiarestado(estado);
            cambiarUbi(ubicacion);
            Latitud = latitud;
            Longitud = longitud;

        }
      
        public TerrenoEntity(string nombre, decimal area)
        {
            cambiarnombre(nombre);
            cambiararea(area);
            Latitud = null;
            Longitud = null;
        }

        public void asignarId (int id)
        { Id_Terreno = id; }
        public void cambiarnombre(string nombre)
        { if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Especificar EL nombre del terreno.");
            Nombre_T = nombre;
        }
        public void cambiararea(decimal area)
        { if (area < 0)
                throw new Exception("El area debe ser mayor a cero.");
            Area = area;
        }
        public void cambiarestado(bool estado)
        { Estado = estado; }
        public void cambiarUbi(string ubicacion)
        {
            if (string.IsNullOrWhiteSpace(ubicacion))
                throw new Exception("La ubicacion no puede estar vacia");
            Ubicacion = ubicacion;

        }

    }

}
