using Azure.Core;
using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO
{
    public class DaoSubfamilia : IDaoSubfamilia
    {
        public List<Subfamilia> GetAll()
        {
            using (var context = new TPVContext())
            {
                return context.Subfamilias.ToList();
            }
        }

        public List<Subfamilia> GetByLikeName(string nom)
        {
            using (var context = new TPVContext())
            {
                return context.Subfamilias.Where(it => nom.ToLower().Contains(it.Nombre.ToLower())).ToList();
            }
        }

        public Subfamilia GetById(int id)
        {
            using (var context = new TPVContext())
            {
                return context.Subfamilias.Where(it=>it.Id==id).FirstOrDefault();    
            }
        }



        public bool PostSubfamilia(Subfamilia subfamilia)
        {
            bool isOk = false;

            using (var context = new TPVContext())
            {
                try
                {
                    context.Subfamilias.Add(subfamilia);
                    context.SaveChanges();
                    isOk = true;
                }
                catch (Exception ex)
                {

                }

                return isOk;
            }
        }

        public bool PutSubfamilia(Subfamilia subfamilia)
        {
            bool isOk = false;

            using (var context = new TPVContext())
            {
                try
                {
                    Subfamilia subfamiliaToUpdate = context.Subfamilias.Where(it => it.Id==subfamilia.Id).FirstOrDefault();
                    if (subfamiliaToUpdate!=null)
                    {
                        subfamiliaToUpdate.Nombre = subfamilia.Nombre.ToString();
                        subfamiliaToUpdate.FamiliaId = subfamilia.FamiliaId;
                        context.Subfamilias.Update(subfamilia);
                        context.SaveChanges();
                        isOk = true;
                    }

                }
                catch (Exception ex)
                {

                }

                return isOk;
            }
        }

        public bool DeleteById(int id)
        {
            bool isOk = false;

            using (var context = new TPVContext())
            {
                try
                {
                    context.Subfamilias.Remove(GetById(id));
                }
                catch (Exception ex)
                {

                }
            }

            return isOk;

        }
    }
}
