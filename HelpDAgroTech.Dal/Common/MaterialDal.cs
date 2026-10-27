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
    public class MaterialDal
    {
        public async Task<List<MaterialEntity>> MostrarMaterialAsincrono(string buscra = null)
        {
            var lista = new List<MaterialEntity>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_listar_materiales", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@buscar", (object)buscra ?? DBNull.Value);
                    await cn.OpenAsync();
                    using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            MaterialEntity ma = new MaterialEntity();

                            ma.AsignarId(Convert.ToInt32(dr["Id"]));
                            ma.CambiarNombreMate(dr["Nombre_material"].ToString());
                            ma.CambiarNombreCategoria(dr["Categoria"].ToString());
                            ma.CambiarUnadadMate(dr["Unidad_material"].ToString());
                            ma.CambiarStock(Convert.ToInt32(dr["Stock"]));
                            ma.CambiarStockMinimo(Convert.ToInt32(dr["Stock_minimo"]));
                            ma.Cambiarprecio(Convert.ToInt32(dr["Precio"]));

                            


                            lista.Add(ma);
                        }
                    }
                }
                return lista;
            }

        }

        public async Task<bool> InsertarMaterialAsync(string nombre, int idCategoria, string unidad, decimal stock, decimal stockMinimo, decimal precio)
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_agregarmaterial", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre_material", nombre);
                        cmd.Parameters.AddWithValue("@Id_Categoria", idCategoria);
                        cmd.Parameters.AddWithValue("@Unidad_material", string.IsNullOrEmpty(unidad) ? (object)DBNull.Value : unidad);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Stock_minimo", stockMinimo);
                        cmd.Parameters.AddWithValue("@Precio", precio);

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
