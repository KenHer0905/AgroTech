using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDAgroTech.Entities.Entidades
{
    public class MaterialEntity
    {
        public int Id_Material { get; set; }
        public string Nombre_material { get; set; } = string.Empty;
        public int Id_Categoria { get; set; }
        public string Unidad_material { get; set; } = string.Empty;


        public decimal Stock { get; set; }
        public decimal Stock_minimo { get; set; }
        public decimal Precio { get; set; }
        public string Nombre_categoria { get; set; } = string.Empty;

        public MaterialEntity()
        {

        }

        public MaterialEntity(string nombreMate, int IdCategoria, string unidadma, int stock, int stockMinimo, decimal precio)
        {
            CambiarNombreMate(nombreMate);
            CambiarUnadadMate(unidadma);
            CambiarStock(stock);
            CambiarStockMinimo(stockMinimo);
            Cambiarprecio(precio);

        }

        public void AsignarId(int id)
        {
            Id_Material = id;
        }

        public void CambiarNombreMate(string nombreMate)
        {
            if (string.IsNullOrWhiteSpace(nombreMate))
                throw new Exception("Especificar el nombre del material");


            Nombre_material = nombreMate.Trim();
        }
        public void CambiarUnadadMate(string unidadma)
        {
            if (string.IsNullOrWhiteSpace(unidadma))
                throw new Exception("Especificar la unidad de medida del material");


           Unidad_material = unidadma.Trim();
        }

        public void CambiarStock(int stock)
        {
            if (stock < 0)
                throw new Exception("El stock no puede ser negativo.");

            Stock = stock;
        }

        public void CambiarStockMinimo(int stockMinimo)
        {
            
            if (stockMinimo < 0)
                throw new Exception("El stock mínimo no puede ser negativo.");

            Stock_minimo = stockMinimo;
        
        }

        public void Cambiarprecio(decimal precio)
        {
            if (precio < 0)
                throw new Exception("El precio no puede ser menor a cero.");

            Precio = precio;
        }

        public void CambiarIdCategpria(int idCategoria)
        {
            if (idCategoria <= 0)
                throw new Exception("Deber seleccionar un IdCategoria");

            Id_Categoria = idCategoria;
        }


        public void CambiarNombreCategoria(string nombreCate) => Nombre_categoria = nombreCate;

    }
}
