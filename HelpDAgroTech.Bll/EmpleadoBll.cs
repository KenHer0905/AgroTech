using HelpDAgroTech.Dal;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll
{
    public class EmpleadoBll
    {
        private readonly EmpleadoDAL _empleadoDAL;

        public EmpleadoBll(EmpleadoDAL empleadoDAL)
        {
            _empleadoDAL = empleadoDAL;
        }
        public async Task Agregar(EmpleadoEntity empleado, string contrasena)
        {
            await _empleadoDAL.AgregarEm(empleado);
        }

        public async Task<List<EmpleadoEntity>> MostrarAsincrono(string buscar = null)
        {
            return await
                _empleadoDAL.MostrarAsincrono(buscar);
        }
        public async Task Actualizar(EmpleadoEntity empleado)
        {
            await _empleadoDAL.ActualizarEm(empleado); 
        }

    }
}


 
    

