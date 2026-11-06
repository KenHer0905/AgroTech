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
    public class DecodificacionBll
    {
        private readonly DecodificacionDal _bll = new DecodificacionDal();

       
        public async Task<bool> InsertarMaterialCultAsync(int idMaterial, int idCultivo, decimal cantidadArea, string etapaAplicacion)
        {
            return await _bll.InsertarMaterialCultAsync(idMaterial, idCultivo, cantidadArea, etapaAplicacion);
        }

        public async Task Actualizar(DecodificacionEntity xd)
        {
            await _bll.ActualizarDecodi(xd);
        }

        public async Task<List<DecodificacionEntity>> MostrarMaterialCultAsincrono(string buscar = null)
        {
            return await _bll.MostrarMaterialCultAsincrono(buscar);
        }
    }
}
