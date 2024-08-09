using BackendProyectoTienda.DAO;
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

            return dtoArticulo;
        }

        public static List<DTOArticulo> ConvertirListArticuloToDTO(List<Articulo> articulos)
        {
            List<DTOArticulo> llistaDTO = new List<DTOArticulo> ();

            articulos.ForEach(articulo => { 
                llistaDTO.Add(ConvertirArticuloToDTO (articulo));
            });

            return llistaDTO;
        }

        public static Articulo ConvertirDTOToArticulo(DTOArticulo dtoArticulo)
        {
            Articulo articulo = new Articulo ();
            articulo.Id = dtoArticulo.Id;
            articulo.Codigo = dtoArticulo.Codigo;
            articulo.Nombre = dtoArticulo.Nombre;
            articulo.Descripcion = dtoArticulo.Descripcion;
            articulo.Precio = dtoArticulo.Precio;
            articulo.Stock = dtoArticulo.Stock;
            articulo.Iva = dtoArticulo.Iva;
            articulo.FamiliaId = dtoArticulo.FamiliaId;
            articulo.SubfamiliaId = dtoArticulo.SubfamiliaId;

            return articulo;
        }

        public static List<Articulo> ConvertirListDTOToListArticulo(List<DTOArticulo> listaDTO)
        {
            List<Articulo> articulos = new List<Articulo>();
            listaDTO.ForEach(articulo =>
            {
                articulos.Add(ConvertirDTOToArticulo(articulo));
            });

            return articulos;
        }
    }
}
