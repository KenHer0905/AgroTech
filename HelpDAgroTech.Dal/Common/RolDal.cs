using HelpDAgroTech.Dal.Common;
using HelpDAgroTech.Dal.Cpmmon;
using HelpDAgroTech.Entities.Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HelpDAgroTech.Dal.Common
{
    public class RolDal
    {
        // 1. Mostrar roles paginados (para la tabla principal)
        public async Task<PaginacionEntity<RolEntity>> MostarAsync(int pagina, int tampagina, string? buscar = null)
        {
            try
            {
                PaginacionEntity<RolEntity> resultado = new();
                using SqlConnection cn = Conexion.ObtenerConexion();

                using SqlCommand cmdTotal = new("sp_ContarRole", cn);
                cmdTotal.CommandType = CommandType.StoredProcedure;
                cmdTotal.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());

                await cn.OpenAsync();
                resultado.TotalRegistros = Convert.ToInt32(await cmdTotal.ExecuteScalarAsync());

                using SqlCommand cmd = new("sp_MostrarRoles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());
                cmd.Parameters.AddWithValue("@pagina", pagina);
                cmd.Parameters.AddWithValue("@tampagina", tampagina);

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    RolEntity rol = new();
                    rol.AsiganarId(Convert.ToInt32(dr["Id"]));
                    rol.CambiarRol(dr["rol"].ToString()!);

                    resultado.Registros.Add(rol);
                }

                resultado.PaginaActual = pagina;
                resultado.TamPagina = tampagina;

                return resultado;
            }
            catch (SqlException ex)
            {
                throw SqlError.TraducirError(ex);
            }
        }

        // 2. Mostrar roles activos (para el ComboBox del formulario Empleados)
        public async Task<List<RolEntity>> MostarRolesActivos()
        {
            try
            {
                List<RolEntity> lista = [];
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_MostrarRolesActivos", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    RolEntity rol = new();
                    rol.AsiganarId(Convert.ToInt32(dr["Id"]));
                    rol.CambiarRol(dr["rol"].ToString()!);

                    lista.Add(rol);
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw SqlError.TraducirError(ex);
            }
        }

    }
}