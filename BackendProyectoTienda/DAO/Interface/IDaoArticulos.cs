using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO.Interface
{
    public interface IDaoArticulos
    {
        public List<Articulo> GetArticulos();
        public Articulo GetArticulo(int id);
        public Articulo GetArticuloByCodigo(string codigo);
        public bool PostArticlo(Articulo articulo);
        public bool PutArticlo(Articulo articulo);
        public bool DeleteArticlo(int id);
        public bool DeleteArticuloByCodigo(string codigo);
    }
}
