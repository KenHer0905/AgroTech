using HelpDAgroTech.Dal.Cpmmon;
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
        public async Task<bool> InsertarMaterialAsync(string nombre, int idCategoria, string unidad, decimal stock, decimal stockMinimo, decimal precio)
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_RegistrarMaterial", cn))
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
