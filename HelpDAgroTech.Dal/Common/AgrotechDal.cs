using HelpDAgroTech.Dal.Cpmmon;
using HelpDAgroTech.Entities.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Dal.Common
{
        public class AgrotechDal
        {
        public async Task<AgrotechEntity> ObtenerEstadisticasGeneralesAsync()
        {
            var stats = new AgrotechEntity();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                // Puedes usar un procedimiento almacenado que devuelva las 4 columnas en una sola fila
                using (SqlCommand cmd = new SqlCommand("sp_obtener_estadisticas_dashboard", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await cn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            stats.TerrenosActivos = reader.GetInt32(reader.GetOrdinal("TerrenosActivos"));
                            stats.EmpleadosActivos = reader.GetInt32(reader.GetOrdinal("EmpleadosActivos"));
                            stats.CosechasListas = reader.GetInt32(reader.GetOrdinal("CosechasListas"));
                            stats.GananciasTotales = reader.IsDBNull(reader.GetOrdinal("GananciasTotales"))
     ? 0m
     : Convert.ToDecimal(reader["GananciasTotales"]);
                        }
                    }
                }
            }

            return stats;
        }
    }

 }
