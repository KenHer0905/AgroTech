using HelpDAgroTech.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelpDAgroTech.Dal.Cpmmon
{
    public class Configuraciondall
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "configuracion.json");

        public bool ExisteConfiguracion()
        {
            return File.Exists(rutaArchivo);
        }

        public bool Guardar(ConexioneEntity config)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo)!);

                string json = JsonSerializer.Serialize(config,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(rutaArchivo, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ConexioneEntity? Obtener()
        {
            if (!File.Exists(rutaArchivo))
                return null;

            string json = File.ReadAllText(rutaArchivo);

            return JsonSerializer.Deserialize<ConexioneEntity>(json);
        }

    }
}
