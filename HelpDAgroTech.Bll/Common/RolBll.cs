using HelpDAgroTech.Dal;
using HelpDAgroTech.Entities.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll
{
    public class RolBll
    {
        private readonly RolDal _rolDal;

        public RolBll(RolDal rolDal)
        {
            _rolDal = rolDal;
        }

        public async Task<List<RolEntity>> MostrarRolesActivosAsync()
        {
            return await _rolDal.MostrarRolesActivosAsync();
        }
    }
}
