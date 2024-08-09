using BackendProyectoTienda.DTO;

namespace BackendProyectoTienda.Services.Repository
{
    public interface RepositoryArticulo
    {
        public List<DTOArticulo> GetAll();
        public List<DTOArticulo> GetArticuloByCodigo(string codigo);
        public bool PostArticulo(DTOArticulo dTOArticulo);
        public bool PutArticulo(DTOArticulo dtoArticulo);
        public bool DeleteArticuloByCodigo(string codigo);
    }
}
