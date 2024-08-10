using BackendProyectoTienda.DAO;
using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using BackendProyectoTienda.Utils;

namespace BackendProyectoTienda.Services
{
    public class ServiceSubfamilia : RepositorySubfamilia
    {
        private IDaoSubfamilia _daoSubfamilia;
        public ServiceSubfamilia(IDaoSubfamilia daoSubfamilia)
        {
            this._daoSubfamilia = daoSubfamilia;
        }

        public List<DTOSubfamilia> GetAll()
        {
            return UtilsSubfamilia.ConvertirListSubFamiliaToDTO(_daoSubfamilia.GetAll());
        }

        public List<DTOSubfamilia> GetByLikeName(string name)
        {
            return UtilsSubfamilia.ConvertirListSubFamiliaToDTO(_daoSubfamilia.GetByLikeName(name));
        }

        public DTOSubfamilia GetById(int id)
        {
            return UtilsSubfamilia.ConvertirSubfamiliaToDTO(_daoSubfamilia.GetById(id));
        }

        public bool PostSubfamilia(DTOSubfamilia dTOSubfamilia)
        {

            return _daoSubfamilia.PostSubfamilia(UtilsSubfamilia.ConvertirDTOToSubfamilia(dTOSubfamilia));
        }

        public bool PutSubfamilia(DTOSubfamilia dTOSubfamilia)
        {

            return _daoSubfamilia.PutSubfamilia(UtilsSubfamilia.ConvertirDTOToSubfamilia(dTOSubfamilia));

        }

        public bool DeleteSubfamilia(int id)
        {

            return _daoSubfamilia.DeleteById(id);

        }
    }
}
