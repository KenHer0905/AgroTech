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
    public class DecodificacionDal
    {
        public async Task<bool> InsertarMaterialCultAsync(int idMaterial, int idCultivo, decimal cantidadArea, string etapaAplicacion)
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AgregarMaterialCult", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idMaterial", idMaterial);
                        cmd.Parameters.AddWithValue("@idCultivo", idCultivo);
                        cmd.Parameters.AddWithValue("@cantidadArea", cantidadArea);
                        cmd.Parameters.AddWithValue("@etapaAplicacion", string.IsNullOrEmpty(etapaAplicacion) ? (object)DBNull.Value : etapaAplicacion);

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

        // Método opcional para listar las dosificaciones en el DataGridView de abajo
        public async Task<List<DecodificacionEntity>> MostrarMaterialCultAsincrono(string buscar = null)
        {
            var lista = new List<DecodificacionEntity>();
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_listar_material_cult", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@buscar", (object)buscar ?? DBNull.Value);

                        await cn.OpenAsync();
                        using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                DecodificacionEntity item = new DecodificacionEntity();

                                item.Id_Material_Cult = Convert.ToInt32(dr["Id_Material_Cult"]);
                                item.Id_Material = Convert.ToInt32(dr["Id_Material"]);
                                item.Id_Cultivo = Convert.ToInt32(dr["Id_Cultivo"]);
                                item.Cantidad_Area = Convert.ToDecimal(dr["Cantidad_Area"]);
                                item.Etapa_Aplicacion = dr["Etapa_Aplicacion"].ToString();

                                // Si tu procedimiento hace JOIN y devuelve los nombres, puedes mapearlos aquí:
                                // item.Nombre_Material = dr["Nombre_material"].ToString();
                                // item.Nombre_Cultivo = dr["Nombre_cultivo"].ToString();

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
