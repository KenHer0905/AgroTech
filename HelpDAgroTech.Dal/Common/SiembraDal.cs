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
    public class SiembraDal
    {
        public async Task<List<SiembraEntity>> MostrarSiembraAsincrono(string buscar = null)
        {
            var lista = new List<SiembraEntity>();
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_listar_siembra", cn)) 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@buscar", (object)buscar ?? DBNull.Value);

                        await cn.OpenAsync();
                        using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                SiembraEntity item = new SiembraEntity();
                                item.Id_Siembra = Convert.ToInt32(dr["Id_Siembra"]);
                                item.Id_Terreno = Convert.ToInt32(dr["Id_Terreno"]);

                                item.NombreTerreno = dr["NombreTerreno"].ToString();

                                item.Id_Cultivo = Convert.ToInt32(dr["Id_Cultivo"]);
                                item.NombreCultivo = dr["Nombre"].ToString();

                                item.Duracion = dr["Duracion"].ToString();
                                item.Fecha = Convert.ToDateTime(dr["Fecha"]);

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

        public async Task<bool> InsertarSiembraAsync(int idTerreno, int idCultivo, string duracion, DateTime fecha)
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_agregarsiembra", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Terreno", idTerreno);
                        cmd.Parameters.AddWithValue("@Id_Cultivo", idCultivo);
                        cmd.Parameters.AddWithValue("@Duracion", duracion);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);

                        await cn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error SQL: " + ex.Message);
            }
        }
        public async Task<bool> ActualizarSiembraAsync(SiembraEntity siembra)
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_actualizarsiembra", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Siembra", siembra.Id_Siembra);
                        cmd.Parameters.AddWithValue("@Id_Terreno", siembra.Id_Terreno);
                        cmd.Parameters.AddWithValue("@Id_Cultivo", siembra.Id_Cultivo);
                        cmd.Parameters.AddWithValue("@Duracion", siembra.Duracion);
                        cmd.Parameters.AddWithValue("@Fecha", siembra.Fecha);

                        await cn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlError.TraducirError(ex);
            }
        }
    }
}
