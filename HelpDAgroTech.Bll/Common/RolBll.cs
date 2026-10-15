using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll.Common
{
    public class RolBll
    {
        private readonly RolDal _rolDal = new();

        // 1. Obtener la lista paginada de roles para la tabla/UI
        public async Task<PaginacionEntity<RolEntity>> MostrarAsync(int pagina, int tampagina, string? buscar = null)
        {
            return await _rolDal.MostarAsync(pagina, tampagina, buscar);
        }

        // 2. Obtener solo roles activos para cargar en el ComboBox de Empleados
        public async Task<List<RolEntity>> MostrarRolesActivosAsync()
        {
            return await _rolDal.MostarRolesActivos();
        }
    }
}
