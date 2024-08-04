using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO.Interface
{
    public interface IDaoEmpresas
    {
        public List<Empresa> Empresas();
        public Empresa GetEmpresaById(int id);

        public bool PostEmpresa(Empresa empresa);

        public bool UpdateEmpresa(Empresa empresa);

        public bool DeleteEmpresa(int id);
    }
}
