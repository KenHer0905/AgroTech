using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class SalidaMaterialEntity
    {
        private DateTime fechaMovimiento;
        private int idEmpleado;
        private int? idTerreno;
        private string? tipoMovimiento;

        public int Id_Movimiento { get; set; }
        public DateTime Fecha_Movimiento { get; set; }
        public int Id_empleado { get; set; }
        public int? Id_Terreno { get; set; } 
        public string Tipo_Movimiento { get; set; }

       
        public string Nombre_empleado { get; set; }
        public string Nombre_T { get; set; }

        public SalidaMaterialEntity()
        {
            // Permite reconstruir la info de la clase cuando se obtiene de la BD
            Fecha_Movimiento = DateTime.Now;
        }

        public SalidaMaterialEntity(int id, DateTime fecha_movimiento, int id_empleado, int? id_terreno, string tipo_movimiento)
        {
            AsignarIdMovimiento(id);
            AsignarFechaMovimiento(fecha_movimiento);
            AsignarIdEmpleado(id_empleado);
            AsignarIdTerreno(id_terreno);
            AsignarTipoMovimiento(tipo_movimiento);
        }

        public SalidaMaterialEntity(DateTime fechaMovimiento, int idEmpleado, int? idTerreno, string? tipoMovimiento)
        {
            this.fechaMovimiento = fechaMovimiento;
            this.idEmpleado = idEmpleado;
            this.idTerreno = idTerreno;
            this.tipoMovimiento = tipoMovimiento;
        }

        #region Métodos 
        public void AsignarIdMovimiento(int id)
        {
            Id_Movimiento = id;
        }

        public void AsignarFechaMovimiento(DateTime fecha)
        {
            if (fecha > DateTime.Now)
                throw new Exception("La fecha del movimiento no puede ser mayor a la actual.");

            Fecha_Movimiento = fecha;
        }

        public void AsignarIdEmpleado(int idEmpleado)
        {
            if (idEmpleado <= 0)
                throw new Exception("Debe seleccionar un empleado válido.");

            Id_empleado = idEmpleado;
        }

        public void AsignarIdTerreno(int? idTerreno)
        {
       
            if (idTerreno.HasValue && idTerreno.Value <= 0)
                throw new Exception("Terreno no es válido.");

            Id_Terreno = idTerreno;
        }

        public void AsignarTipoMovimiento(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new Exception("Debe especificar el tipo de movimiento.");

            string tipoTrim = tipo.Trim();
            if (tipoTrim != "Entrada" && tipoTrim != "Salida")
                throw new Exception("El tipo de movimiento debe ser 'Entrada' o 'Salida'.");

            Tipo_Movimiento = tipoTrim;
        }

        public void AsignarNombreEmpleado(string nombre) => Nombre_empleado = nombre?.Trim();
        public void AsignarNombreTerreno(string nombreTerreno) => Nombre_T = nombreTerreno?.Trim();
        #endregion
    }

    
}
