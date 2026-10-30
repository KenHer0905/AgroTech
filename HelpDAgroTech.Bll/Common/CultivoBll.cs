using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll.Common
{
    public class CultivoBll
    {
        private readonly CultivoDal _dal = new CultivoDal();

        public async Task<List<CultivoEntity>> MostrarCultivosAsincrono(string buscar = null)
        {
            return await _dal.MostrarCultivosAsincrono(buscar);
        }
    }
}
