using HelpDAgroTech.Dal.Cpmmon;
using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Dal.Common
{
    public class SalidamateDal
    {
        public async Task<List<SalidaMaterialEntity>> MostrarSalida(string buscra = null)
        {
            var lista = new List<SalidaMaterialEntity>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_listar_movimientos", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@buscar", (object)buscra ?? DBNull.Value);
                    await cn.OpenAsync();
                    using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            SalidaMaterialEntity emp = new SalidaMaterialEntity();

                            emp.AsignarIdMovimiento(Convert.ToInt32(dr["Id_Movimiento"]));
                            emp.AsignarFechaMovimiento(Convert.ToDateTime(dr["Fecha_Movimiento"]));
                            emp.AsignarIdEmpleado(Convert.ToInt32(dr["Id_empleado"]));
                            emp.AsignarTipoMovimiento(dr["Tipo_Movimiento"].ToString());
                            emp.AsignarNombreEmpleado(dr["Nombre_empleado"].ToString());
                            emp.AsignarIdTerreno(Convert.ToInt32(dr["Id_Terreno"]));
                            emp.AsignarNombreTerreno(dr["Nombre_T"].ToString());

                            lista.Add(emp);
                        }
                    }
                }
                return lista;
            }

        }

        public async Task<bool> InsertarMovimientoAsync(SalidaMaterialEntity movimiento)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("sp_agregar_movimiento", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Fecha_Movimiento", movimiento.Fecha_Movimiento);
                    cmd.Parameters.AddWithValue("@Id_empleado", movimiento.Id_empleado);


                    cmd.Parameters.AddWithValue("@Id_Terreno", movimiento.Id_Terreno.HasValue ? (object)movimiento.Id_Terreno.Value : DBNull.Value);

                    cmd.Parameters.AddWithValue("@Tipo_Movimiento", movimiento.Tipo_Movimiento);

                    await cn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return true;
                }
            }

        }
    }
}

