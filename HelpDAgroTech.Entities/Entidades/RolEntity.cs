using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class RolEntity
    {
        public int Id_Rol { get; private set; }
        public string Rol { get; private set; } = string.Empty;

        public bool Activo { get; private set; }
        public string Estado => Activo ? "Activo" : "Inactivo";

        #region Contructores
        public RolEntity() {}

        public RolEntity (string rol)
        {
            CambiarRol(rol);
            Activo = true; 
        }
        #endregion

        #region Metodos
        public void AsiganarId(int idrol)
        {
            Id_Rol = idrol;
        }
        public void CambiarRol(string rol)
        {
            if (string.IsNullOrWhiteSpace(rol))
                throw new Exception("Debe ingresar dl nombre del rol");
            Rol = rol.Trim();
        }
        public void CambiarEstado(bool activo)
        {
            Activo = activo;
        }
        #endregion

    }
}
