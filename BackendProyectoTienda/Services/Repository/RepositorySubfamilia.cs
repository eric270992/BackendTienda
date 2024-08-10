using BackendProyectoTienda.DTO;

namespace BackendProyectoTienda.Services.Repository
{
    public interface RepositorySubfamilia
    {
        public List<DTOSubfamilia> GetAll();
        public List<DTOSubfamilia> GetByLikeName(string name);
        public DTOSubfamilia GetById(int id);
        public bool PostSubfamilia(DTOSubfamilia dTOSubfamilia);
        public bool PutSubfamilia(DTOSubfamilia dTOSubfamilia);
        public bool DeleteSubfamilia(int id);
    }
}
