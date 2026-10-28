using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll.Common
{
    
        public class CategoriaMAterialBll
        {
            private readonly CategoriaMaterialDAL _categoriaMaterialDAL = new CategoriaMaterialDAL();


            public async Task<List<CategoriaMaterialEntity>> MostrarCategoriasAsync()
            {
                return await _categoriaMaterialDAL.MostrarCategoriasAsync();
            }
        }
    
}
