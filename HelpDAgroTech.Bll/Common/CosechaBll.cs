using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll.Common
{
    public class CosechaBll
    {

        private CosechaDal _cosechaDal = new CosechaDal();

        public async Task<List<CosechaEntity>> ObtenerListadoCosechasAsync()
        {
            try
            {
                return await _cosechaDal.ObtenerCosechasAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BLL al obtener cosechas: " + ex.Message);
            }
        }

        public async Task<List<CosechaEntity>> FiltrarCosechasPorFechaAsync(DateTime inicio, DateTime fin)
        {
            return await _cosechaDal.FiltrarCosechasPorFechaAsync(inicio, fin);
        }

        public async Task<bool> RegistrarCosechaAsync(CosechaEntity cosecha)
        {
            try
            {
                if (cosecha.Id_Siembra <= 0)
                    throw new Exception("Debe seleccionar una siembra válida para registrar la cosecha.");

                if (cosecha.Cantidad <= 0)
                    throw new Exception("La cantidad cosechada debe ser mayor a cero.");

                if (string.IsNullOrWhiteSpace(cosecha.Unidad_Medida))
                    cosecha.Unidad_Medida = "Quintales";

                if (cosecha.Fecha < new DateTime(1753, 1, 1))
                    throw new Exception("La fecha de cosecha no es válida.");

                return await _cosechaDal.InsertarCosechaAsync(cosecha);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BLL al registrar cosecha: " + ex.Message);
            }
        }
    
    }
}
