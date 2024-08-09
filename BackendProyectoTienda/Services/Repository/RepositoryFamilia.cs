using BackendProyectoTienda.DTO;

namespace BackendProyectoTienda.Services.Repository
{
    public interface RepositoryFamilia
    {
        public List<DTOFamilia> GetAll();
        public List<DTOFamilia> GetAllByName(string name);
        public DTOFamilia GetById(int id);
        public bool PostFamilia(DTOFamilia familia);
        public bool PutFamilia(DTOFamilia familia);
        public bool DeleteFamilia(int id);
    }
}
