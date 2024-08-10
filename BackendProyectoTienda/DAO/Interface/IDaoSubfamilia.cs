using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO.Interface
{
    public interface IDaoSubfamilia
    {
        public List<Subfamilia> GetAll();
        public List<Subfamilia> GetByLikeName(string nom);
        public Subfamilia GetById(int id);

        public bool PostSubfamilia(Subfamilia subfamilia);
        public bool PutSubfamilia(Subfamilia subfamilia);
        public bool DeleteById(int id);

    }
}
