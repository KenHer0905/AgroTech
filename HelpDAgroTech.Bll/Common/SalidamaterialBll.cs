using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelpDAgroTech.Bll.Common.SalidamaterialBll;

namespace HelpDAgroTech.Bll.Common
{
    public class SalidamaterialBll
    {
          private readonly SalidamateDal _salidaDal;

          
            public SalidamaterialBll()
            {
                _salidaDal = new SalidamateDal();
            }

    
            public SalidamaterialBll(SalidamateDal salidaDal)
            {
                _salidaDal = salidaDal;
            }

            
            public async Task<bool> RegistrarMovimientoAsync(SalidaMaterialEntity movimiento)
            {
                try
                {
                    return await _salidaDal.InsertarMovimientoAsync(movimiento);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la capa de negocio al registrar el movimiento: " + ex.Message);
                }
            }
        
    }
}
