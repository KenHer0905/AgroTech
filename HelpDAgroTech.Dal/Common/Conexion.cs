using Microsoft.Data.SqlClient;


namespace HelpDAgroTech.Dal.Cpmmon
{
    public class Conexion
    {
        public static string CadenaConexion { get; set; } = string.Empty;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }

    }
}
