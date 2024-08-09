using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.Utils
{
    public static class UtilsArticulo
    {
        public static DTOArticulo ConvertirArticuloToDTO(Articulo articulo)
        {
            DTOArticulo dtoArticulo = new DTOArticulo();
            dtoArticulo.Id = articulo.Id;
            dtoArticulo.Codigo = articulo.Codigo;
            dtoArticulo.Nombre = articulo.Nombre;
            dtoArticulo.Descripcion = articulo.Descripcion;
            dtoArticulo.Precio = articulo.Precio;
            dtoArticulo.Stock = articulo.Stock;
            dtoArticulo.Iva = articulo.Iva;
            dtoArticulo.FamiliaId = articulo.FamiliaId;
            dtoArticulo.SubfamiliaId = articulo.SubfamiliaId;

        }
    }
}
