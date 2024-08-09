using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO
{
    public class DaoFamilia : IDaoFamilia
    { 
        public List<Familia> GetAll()
        {
            using (var context = new TPVContext())
            {
                return context.Familias.ToList();
            }
        }

        public Familia GetById(int id)
        {
            using(var context = new TPVContext())
            {
                return context.Familias.Where(it => it.Id == id).FirstOrDefault();
            }
        }

        public List<Familia> GetByLikeNombre(string nombre)
        {
            using (var context = new TPVContext())
            {
                return context.Familias.Where(it => it.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
            }
        }

        public bool PostFamilia(Familia familia)
        {
            bool isOk = false;
            using(var context = new TPVContext())
            {
                try
                {
                    context.Add(familia);
                    isOk = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                return isOk;
            }
        }

        public bool PutFamilia(Familia familia)
        {
            bool isOk = false;
            using (var context = new TPVContext())
            {
                try
                {
                    context.Update(familia);
                    isOk = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                return isOk;
            }
        }

        public bool DeleteFamilia(int id)
        {
            bool isOk = false;
            using (var context = new TPVContext())
            {
                try
                {
                    Familia fam = context.Familias.Where(it => it.Id  == id).FirstOrDefault();
                    if (fam != null)
                    {
                        context.Familias.Remove(fam);
                        isOk = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                return isOk;
            }
        }
    }
}
