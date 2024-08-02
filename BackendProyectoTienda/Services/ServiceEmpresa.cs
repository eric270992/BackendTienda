using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using BackendProyectoTienda.Utils;

namespace BackendProyectoTienda.Services
{
    public class ServiceEmpresa : RepositoryEmpresa
    {
        public IDaoEmpresas _daoEmpresa;
        public ServiceEmpresa(IDaoEmpresas daoEmpresas)
        {
            _daoEmpresa = daoEmpresas;
        }

        public List<DTOEmpresa> GetEmpreses()
        {
            return UtilsEmpresa.ConvertiListEmpresaToListDTOEmpresa(_daoEmpresa.Empresas());
        }

        public DTOEmpresa GetEmpresaById(int id)
        {
            return UtilsEmpresa.ConvertirEmpresaToDtoEmpresa(_daoEmpresa.GetEmpresaById(id));
        }
    }
}
