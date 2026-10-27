using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Dal.Cpmmon;
using HelpDAgroTech.Entities.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace HelpDAgroTech.Dal
{
    public class RolDal
    {
        public async Task<List<RolEntity>> MostrarRolesActivosAsync()
        {
            var lista = new List<RolEntity>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_mostrar_roles_activos", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await cn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            RolEntity rol = new RolEntity();
                            rol.AsiganarId(reader.GetInt32(reader.GetOrdinal("Id_Rol")));
                            rol.CambiarRol(reader.GetString(reader.GetOrdinal("Rol")));

                            // Como tu entidad usa el método CambiarEstado y la propiedad Activo:
                            bool estadoBd = reader.GetBoolean(reader.GetOrdinal("Estado"));
                            rol.CambiarEstado(estadoBd);

                            lista.Add(rol);
                        }
                    }
                }
            }

            return lista;
        }
    }
}