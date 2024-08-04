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

        public Wrapper PostEmpresa(DTOEmpresa dtoEmpresa)
        {
            Wrapper wrapper = new Wrapper();
            wrapper.Status = "500";
            wrapper.Message = "Empresa afegida correctament";
            wrapper.Data = null;

            _daoEmpresa.PostEmpresa(UtilsEmpresa.ConvertirDtoEmpresaToEmpresa(dtoEmpresa));

            return wrapper;
        }

        public Wrapper PutEmpresa(DTOEmpresa dtoEmpresa)
        {
            throw new NotImplementedException();
        }


        public Wrapper DeleteEmpresa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
