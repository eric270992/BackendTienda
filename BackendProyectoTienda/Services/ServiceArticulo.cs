using BackendProyectoTienda.DAO;
using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using BackendProyectoTienda.Utils;

namespace BackendProyectoTienda.Services
{
    public class ServiceArticulo : RepositoryArticulo
    {
        private IDaoArticulos _daoArticulo;
        public ServiceArticulo(IDaoArticulos daoArticulo)
        {
            _daoArticulo = daoArticulo;
        }


        public List<DTOArticulo> GetAll()
        {
            return UtilsArticulo.ConvertirListArticuloToDTO(_daoArticulo.GetArticulos());
        }

        public DTOArticulo GetArticuloByCodigo(string codigo)
        {
            return UtilsArticulo.ConvertirArticuloToDTO(_daoArticulo.GetArticuloByCodigo(codigo));
        }

        public bool PostArticulo(DTOArticulo dtoArticulo)
        {
            return _daoArticulo.PostArticulo(UtilsArticulo.ConvertirDTOToArticulo(dtoArticulo));
        }

        public bool PutArticulo(DTOArticulo dtoArticulo)
        {
            return _daoArticulo.PutArticlo(UtilsArticulo.ConvertirDTOToArticulo(dtoArticulo));
        }

        public bool DeleteArticuloByCodigo(string codigo)
        {
            return _daoArticulo.DeleteArticuloByCodigo(codigo);
        }
    }
}
