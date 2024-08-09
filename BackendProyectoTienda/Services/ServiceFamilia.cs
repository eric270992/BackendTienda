using Azure.Core;
using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using BackendProyectoTienda.Utils;

namespace BackendProyectoTienda.Services
{
    public class ServiceFamilia : RepositoryFamilia
    {
        private IDaoFamilia _daoFamilia;

        public ServiceFamilia(IDaoFamilia daoFamilia)
        {
            _daoFamilia = daoFamilia;
        }

        public List<DTOFamilia> GetAll()
        {
            return UtilsFamilia.ConvertirListFamiliaToDTO(_daoFamilia.GetAll());
        }

        public List<DTOFamilia> GetAllByName(string name)
        {
            return UtilsFamilia.ConvertirListFamiliaToDTO(_daoFamilia.GetByLikeNombre(name));
        }

        public DTOFamilia GetById(int id)
        {
            return UtilsFamilia.ConvertirFamiliaToDTO(_daoFamilia.GetById(id));
        }

        public bool PostFamilia(DTOFamilia familia)
        {
            return _daoFamilia.PostFamilia(UtilsFamilia.ConvertirDTOToFamilia(familia));
        }

        public bool PutFamilia(DTOFamilia familia)
        {
            return _daoFamilia.PutFamilia(UtilsFamilia.ConvertirDTOToFamilia(familia));
        }

        public bool DeleteFamilia(int id)
        {
            return _daoFamilia.DeleteFamilia(id);
        }
    }
}
