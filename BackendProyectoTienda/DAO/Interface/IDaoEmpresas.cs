using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO.Interface
{
    public interface IDaoEmpresas
    {
        public List<Empresa> Empresas();
        public Empresa GetEmpresaById(int id);
    }
}
