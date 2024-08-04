using BackendProyectoTienda.DTO;

namespace BackendProyectoTienda.Services.Repository
{
    public interface RepositoryEmpresa
    {
        public List<DTOEmpresa> GetEmpreses();
        public DTOEmpresa GetEmpresaById(int id);

        public Wrapper PutEmpresa(DTOEmpresa empresa);

        public Wrapper PostEmpresa(DTOEmpresa empresa);

        public Wrapper DeleteEmpresa(int id);
    }
}
