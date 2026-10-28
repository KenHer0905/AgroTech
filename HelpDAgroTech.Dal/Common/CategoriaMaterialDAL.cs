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
    public class CategoriaMaterialDAL
    {
        public async Task<List<CategoriaMaterialEntity>> MostrarCategoriasAsync()
        {
            var lista = new List<CategoriaMaterialEntity>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_listar_categorias", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await cn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            CategoriaMaterialEntity CategoriaMA = new CategoriaMaterialEntity();
                            CategoriaMA.asignarid(reader.GetInt32(reader.GetOrdinal("Id_Categoria")));
                            CategoriaMA.CambiarnombreCate(reader.GetString(reader.GetOrdinal("Nombre_categoria")));

                            lista.Add(CategoriaMA);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
