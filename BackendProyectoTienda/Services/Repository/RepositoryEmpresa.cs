using BackendProyectoTienda.DTO;

namespace BackendProyectoTienda.Services.Repository
{
    public interface RepositoryEmpresa
    {
        public List<DTOEmpresa> GetEmpreses();
        public DTOEmpresa GetEmpresaById(int id);
    }
}
