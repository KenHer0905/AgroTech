using HelpDAgroTech.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Bll
{
    public class SistemaBll
    {
        private readonly SistemaDal _sistemaDal;
        public  SistemaBll(SistemaDal sistemaDal)
        {
            _sistemaDal = sistemaDal;
        }

       /* public async  Task CrearAdministradorInicialAsync()
        {
            await _sistemaDal.CrearAdministradorInicialAsync();
        }*/
    }
}
