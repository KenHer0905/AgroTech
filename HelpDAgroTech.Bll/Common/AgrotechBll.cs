using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll.Common
{
    public class AgrotechBll
    {
       
            private AgrotechDal _dalba = new AgrotechDal();

        public async Task<AgrotechEntity> ObtenerEstadisticasGeneralesAsync()
        {
            return await _dalba.ObtenerEstadisticasGeneralesAsync();
        }

    }
}
