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
    public class CosechaDal
    {


        public async Task<bool> InsertarCosechaAsync(CosechaEntity cosecha)
        {
            string query = @"INSERT INTO Cosecha (Id_Siembra, Cantidad, unidad_medida, fecha) 
                             VALUES (@IdSiembra, @Cantidad, @UnidadMedida, @Fecha)";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.Add("@IdSiembra", SqlDbType.Int).Value = cosecha.Id_Siembra;
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = cosecha.Cantidad;
                    cmd.Parameters.Add("@UnidadMedida", SqlDbType.VarChar, 20).Value = cosecha.Unidad_Medida;
                    cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = cosecha.Fecha;

                    await cn.OpenAsync();
                    int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                    return filasAfectadas > 0;
                }
            }
        }

        public async Task<List<CosechaEntity>> ObtenerCosechasAsync()
        {
            var lista = new List<CosechaEntity>();

            string query = @"SELECT 
                                c.Id_cosecha,
                                c.Id_Siembra,
                                c.Cantidad,
                                c.unidad_medida,
                                c.fecha
                            FROM Cosecha c
                            INNER JOIN Siembra s ON c.Id_Siembra = s.Id_Siembra
                            ORDER BY c.fecha DESC";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    await cn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            CosechaEntity item = new CosechaEntity
                            {
                                Id_cosecha = reader.GetInt32(reader.GetOrdinal("Id_cosecha")),
                                Id_Siembra = reader.GetInt32(reader.GetOrdinal("Id_Siembra")),
                                Cantidad = reader.GetDecimal(reader.GetOrdinal("Cantidad")),
                                Unidad_Medida = reader.GetString(reader.GetOrdinal("unidad_medida")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("fecha"))
                            };
                            lista.Add(item);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task<List<CosechaEntity>> FiltrarCosechasPorFechaAsync(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = new List<CosechaEntity>();

            string query = @"SELECT 
                                c.Id_cosecha,
                                c.Id_Siembra,
                                c.Cantidad,
                                c.unidad_medida,
                                c.fecha
                            FROM Cosecha c
                            INNER JOIN Siembra s ON c.Id_Siembra = s.Id_Siembra
                            WHERE c.fecha BETWEEN @FechaInicio AND @FechaFin
                            ORDER BY c.fecha DESC";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fechaInicio;
                    cmd.Parameters.Add("@FechaFin", SqlDbType.Date).Value = fechaFin;

                    await cn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            CosechaEntity item = new CosechaEntity
                            {
                                Id_cosecha = reader.GetInt32(reader.GetOrdinal("Id_cosecha")),
                                Id_Siembra = reader.GetInt32(reader.GetOrdinal("Id_Siembra")),
                                Cantidad = reader.GetDecimal(reader.GetOrdinal("Cantidad")),
                                Unidad_Medida = reader.GetString(reader.GetOrdinal("unidad_medida")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("fecha"))
                            };
                            lista.Add(item);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
