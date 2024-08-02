using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO
{
    public class DaoEmpresa : IDaoEmpresas
    {
        public DaoEmpresa() { }

        public List<Empresa> Empresas()
        {
            using (TPVContext context = new TPVContext())
            {
                List<Empresa> empresas = new List<Empresa>();
                empresas = context.Empresas.ToList();
                return empresas;
            }
        }
        public Empresa GetEmpresaById(int id)
        {
            using(TPVContext context = new TPVContext())
            {
                return context.Empresas.Where(it => it.Id == id).FirstOrDefault();
            }
        }
    }
}
