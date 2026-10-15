using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class ConexioneEntity
    {
        public string Servidor { get; set; } = string.Empty;
        public string BaseDatos { get; set; } = string.Empty;
        public string UsuarioSql { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
