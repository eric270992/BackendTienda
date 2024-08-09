using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;

namespace BackendProyectoTienda.Services
{
    public class ServiceArticulo : RepositoryArticulo
    {
        private IDaoArticulos _daoArticulo;
        public ServiceArticulo(IDaoArticulos daoArticulo)
        {
            _daoArticulo = daoArticulo;
        }
        public bool DeleteArticuloByCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<DTOArticulo> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<DTOArticulo> GetArticuloByCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public bool PostArticulo(DTOArticulo dTOArticulo)
        {
            throw new NotImplementedException();
        }

        public bool PutArticulo(DTOArticulo dtoArticulo)
        {
            throw new NotImplementedException();
        }
    }
}
