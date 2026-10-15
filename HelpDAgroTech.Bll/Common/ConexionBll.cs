using Microsoft.Data.SqlClient;
namespace HelpDAgroTech.Bll.Common
{
    public class ConexionBll
    {
        public async Task<bool> ProbarConexion(string servidor, string baseDatos, string usuarioSql, string password)
        {
            string cadena =
                $"Server={servidor};" +
                $"Database={baseDatos};" +
                $"User Id={usuarioSql};" +
                $"Password={password};" +
                $"TrustServerCertificate=True;";

            try
            {
                using SqlConnection cn = new(cadena);

                await cn.OpenAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
