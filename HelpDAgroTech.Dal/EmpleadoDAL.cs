using HelpDAgroTech.Dal.Cpmmon;
using HelpDAgroTech.Entities.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Dal
{
    public class EmpleadoDAL
    {
        public async Task ActualizarEm(EmpleadoEntity empleado)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarEmpleado", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_empleado", empleado.Id_empleado);
                    cmd.Parameters.AddWithValue("@nombre_emnue", empleado.Nombre_empleado);
                    cmd.Parameters.AddWithValue("@Telefononuevo", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Contrasena", empleado.Contrasena);
                    cmd.Parameters.AddWithValue("@Id_Rol", empleado.Id_Rol);

                    await cn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                }
            }

        }


        public async Task<List<EmpleadoEntity>> MostrarAsincrono(string buscra = null)
        {
            var lista = new List<EmpleadoEntity>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("Sp_listarEmpleados", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@buscar", (object)buscra ?? DBNull.Value);
                    await cn.OpenAsync();
                    using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            EmpleadoEntity emp = new EmpleadoEntity();

                            emp.AsignarId(Convert.ToInt32(dr["Id"]));
                            emp.CambiarNombreEmpleado(dr["Nombre_empleado"].ToString());
                            emp.CambiarTelefono(dr["Telefono"].ToString());
                            emp.CambiarEstado(Convert.ToBoolean(dr["Estado"]));
                            emp.CambiarCedula(dr["Cedula"].ToString());
                            emp.CambiarFechaNacimiento(Convert.ToDateTime(dr["Fecha_nacimiento"]));
                            emp.CambiarRol(dr["Rol"]?.ToString() ?? string.Empty);
                            emp.CambiarContrasena(dr["Contrasena"].ToString());

                            lista.Add(emp);
                        }
                    }
                }
                return lista;
            }

        }

        public async Task AgregarEm(EmpleadoEntity empleado)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_agregarempleados", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre_em", empleado.Nombre_empleado);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", empleado.Estado);
                    cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                    cmd.Parameters.AddWithValue("@Fecha_nacimiento", empleado.Fecha_nacimiento);
                    cmd.Parameters.AddWithValue("@Contrasena", empleado.Contrasena);
                    cmd.Parameters.AddWithValue("@Id_Rol", empleado.Id_Rol);

                    await cn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }
    }
}
