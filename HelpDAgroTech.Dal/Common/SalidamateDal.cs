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
        public async Task<DataTable> ObtenerVistaPreviaMaterialesAsync(int idTerreno)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"
                SELECT                 
                    m.Id_material,
                    m.Nombre_material,
                    (m.Precio * (mc.Cantidad_Area * t.Area)) as Precio,
                    (mc.Cantidad_Area * t.Area) as CantidadCalculada
                FROM Terreno t
                INNER JOIN Siembra s ON t.Id_Terreno = s.Id_Terreno
                INNER JOIN Material_Cult mc ON s.Id_Cultivo = mc.Id_Cultivo
                INNER JOIN Material m ON mc.Id_Material = m.Id_material
                WHERE t.Id_Terreno = @Id_Terreno";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Terreno", idTerreno);
                    await cn.OpenAsync();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
        }

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

        public async Task InsertarMovimientoAsync(SalidaMaterialEntity movimiento)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                await cn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand("sp_registrar_salida_movimiento_completo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Fecha_Movimiento", movimiento.Fecha_Movimiento);
                    cmd.Parameters.AddWithValue("@Id_empleado", movimiento.Id_empleado);
                    cmd.Parameters.AddWithValue("@Id_Terreno", movimiento.Id_Terreno); // <--- ¡Asegúrate de que esta línea esté presente!
                    cmd.Parameters.AddWithValue("@Tipo_Movimiento", movimiento.Tipo_Movimiento);

                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }
    }
}

