using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll.Common
{
    public class SiembraBll
    {
        private readonly SiembraDal _dal = new SiembraDal();

        public async Task<List<SiembraEntity>> MostrarSiembraAsincrono(string buscar = null)
        {
            return await _dal.MostrarSiembraAsincrono(buscar);
        }

        public async Task<bool> InsertarSiembraAsync(int idTerreno, int idCultivo, string duracion, DateTime fecha)
        {
            return await _dal.InsertarSiembraAsync(idTerreno, idCultivo, duracion, fecha);
        }
    }
}
