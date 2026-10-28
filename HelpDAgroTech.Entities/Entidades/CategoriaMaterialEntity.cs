using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelpDAgroTech.Entities.Entidades
{
    public class CategoriaMaterialEntity
    {
        public int Id_Categoria { get; private set; }
        public string Nombre_categoria { get; private set; } = string.Empty;
        public string Descripcio { get; private set; } = string.Empty;

        #region constructores
        public CategoriaMaterialEntity() { }

        public CategoriaMaterialEntity(string nombreCa, string descripcio)
        {
            CambiarnombreCate(nombreCa);
            cambiarDescripcion(descripcio);
        }

        #endregion

        #region Metodos
        public void asignarid(int id)
        {
            Id_Categoria = id;
        }

        public void CambiarnombreCate(string nombreCa)
        {
            if (string.IsNullOrWhiteSpace(nombreCa))
                throw new Exception("Especificar el nombre de la categoria");
            Nombre_categoria = nombreCa.Trim();
        }

        public void cambiarDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new Exception("Especificar la descripcion");
            Nombre_categoria = descripcion.Trim();
        }

        #endregion
    }
}
