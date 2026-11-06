using HelpDAgroTech.Dal;
using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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

        public async Task<List<SalidaMaterialEntity>> MostrarAsincrono(string buscar = null)
        {
            return await
                _salidaDal.MostrarSalida(buscar);
        }

        public async Task<DataTable> ObtenerVistaPreviaMaterialesAsync(int idTerreno)
        {
            try
            {
                return await _salidaDal.ObtenerVistaPreviaMaterialesAsync(idTerreno);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al obtener la vista previa de materiales: " + ex.Message);
            }
        }

        public async Task RegistrarMovimientoAsync(SalidaMaterialEntity movimiento)
        {
           
            if (movimiento.Fecha_Movimiento < new DateTime(1753, 1, 1))
            {
                movimiento.AsignarFechaMovimiento(DateTime.Now); 
            }
            await _salidaDal.InsertarMovimientoAsync(movimiento);
        }


        public async Task<List<SalidaMaterialEntity>> MostrarSalida()
        {
            try
            {
                return await _salidaDal.MostrarSalida(); // Asegúrate de que el método en tu DAL tenga un nombre similar
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al obtener los movimientos: " + ex.Message);
            }
        }
    }
}
