using HelpDAgroTech.Dal;
using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll.Common
{
    public class TerrenoBll
    {
        // Instanciamos correctamente la capa de acceso a datos (DAL)
        private TerrenoDal _terrenoDal = new TerrenoDal();

        public async Task Actualizar(TerrenoEntity terreno)
        {
            await _terrenoDal.ActualizarTerreno(terreno);
        }
        public async Task agregart(TerrenoEntity terreno)
        {
            await _terrenoDal.agregarterreno(terreno);
        }
        public async Task<List<TerrenoEntity>> MostrarTerrenosAsincrono(string buscar = null)
        {
            return await _terrenoDal.MostrarTerrenosAsincrono(buscar);
        }
    }
}
