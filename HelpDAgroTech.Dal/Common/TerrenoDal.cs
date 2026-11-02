using HelpDAgroTech.Dal.Cpmmon;
using HelpDAgroTech.Entities.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Dal.Common
{
    public class TerrenoDal
    {
        public async Task ActualizarTerreno(TerrenoEntity terreno)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_editarInfoTerren", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Terreno", terreno.Id_Terreno);
                    cmd.Parameters.AddWithValue("@Nombre_T", terreno.Nombre_T);
                    cmd.Parameters.AddWithValue("@Area", terreno.Area);
                    cmd.Parameters.AddWithValue("@Latitud", terreno.Latitud);
                    cmd.Parameters.AddWithValue("@Longuitud", terreno.Longitud);

                    await cn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                }
            }

        }
        public async Task agregarterreno(TerrenoEntity terreno)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using(SqlCommand cmd = new SqlCommand("sp_anadirterreno", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre_T", terreno.Nombre_T);
                    cmd.Parameters.AddWithValue("@Area", terreno.Area);
                    cmd.Parameters.AddWithValue("@Estado", terreno.Estado);
                    cmd.Parameters.AddWithValue("@Ubicacion", terreno.Ubicacion);
                    cmd.Parameters.AddWithValue("@Latitud", terreno.Latitud);
                    cmd.Parameters.AddWithValue("@Longuitud", terreno.Longitud);

                    await cn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

        public async Task<List<TerrenoEntity>> MostrarTerrenosAsincrono(string buscar = null)
        {
            var lista = new List<TerrenoEntity>();
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    string query = @"
                        SELECT Id_Terreno, Nombre_T, Area, Estado, Ubicacion, Latitud, Longitud
                        FROM Terreno
                        WHERE @buscar IS NULL 
                           OR Nombre_T LIKE '%' + @buscar + '%' 
                           OR Ubicacion LIKE '%' + @buscar + '%'";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@buscar", (object)buscar ?? DBNull.Value);

                        await cn.OpenAsync();
                        using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                TerrenoEntity item = new TerrenoEntity();
                                item.Id_Terreno = Convert.ToInt32(dr["Id_Terreno"]);
                                item.Nombre_T = dr["Nombre_T"].ToString();
                                item.Area = Convert.ToDecimal(dr["Area"]);
                                item.Estado = Convert.ToBoolean(dr["Estado"]);
                                item.Ubicacion = dr["Ubicacion"].ToString();
                                item.Latitud = dr["Latitud"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["Latitud"]);
                                item.Longitud = dr["Longitud"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["Longitud"]);

                                lista.Add(item);
                            }
                        }
                    }
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
