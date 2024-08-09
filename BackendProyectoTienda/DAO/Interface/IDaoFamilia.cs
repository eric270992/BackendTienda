using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO.Interface
{
    public interface IDaoFamilia
    {
        public List<Familia> GetAll();
        public List<Familia> GetByLikeNombre(string nombre);
        public Familia GetById(int id);
        public bool PostFamilia(Familia familia);
        public bool PutFamilia(Familia familia);
        public bool DeleteFamilia(int id);

    }
}
