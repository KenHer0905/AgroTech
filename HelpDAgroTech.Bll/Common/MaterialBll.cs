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
    public class MaterialBll
    {
        private readonly MaterialDal _materialDal = new MaterialDal();
        public async Task<List<MaterialEntity>> MostrarMaterialAsincrono(string buscar = null)
        {
            return await
                _materialDal.MostrarMaterialAsincrono(buscar);
        }

        public async Task<bool> InsertarMaterialAsync(string nombre, int idCategoria, string unidad, decimal stock, decimal stockMinimo, decimal precio)
        {
            return await _materialDal.InsertarMaterialAsync(nombre, idCategoria, unidad, stock, stockMinimo,precio);
        }
    }
}
