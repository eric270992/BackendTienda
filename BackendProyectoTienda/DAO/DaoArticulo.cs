using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.DAO
{
    public class DaoArticulo : IDaoArticulos
    {
        public DaoArticulo()
        {
        }

        public List<Articulo> GetArticulos()
        {
            using (TPVContext context = new TPVContext())
            {
                return context.Articulos.ToList();
            }
        }

        public Articulo GetArticulo(int id)
        {
            using (TPVContext context = new TPVContext())
            {
                return context.Articulos.Where(it => it.Id == id).FirstOrDefault();
            }
        }

        public Articulo GetArticuloByCodigo(string codigo)
        {
            using (TPVContext context = new TPVContext())
            {
                return context.Articulos.Where(it => it.Codigo==codigo).FirstOrDefault();
            }
        }

        public bool PostArticulo(Articulo articulo)
        {
            bool isOk = true;

            using(TPVContext context = new TPVContext())
            {
                try
                {
                    context.Articulos.Add(articulo);
                }
                catch (Exception ex)
                {
                    isOk = false;
                }

                return isOk;
            }
        }

        public bool PutArticlo(Articulo articulo)
        {
            bool isOk = true;

            using (TPVContext context = new TPVContext())
            {
                try
                {
                    Articulo articuloToUpdate = context.Articulos.Where(it => it.Id == articulo.Id).FirstOrDefault();
                    if (articuloToUpdate != null)
                    {
                        articuloToUpdate.Nombre = articulo.Nombre;
                        articuloToUpdate.Descripcion = articulo.Descripcion;
                        articuloToUpdate.Precio = articulo.Precio;
                        articuloToUpdate.Iva = articulo.Iva;

                        context.Articulos.Update(articuloToUpdate);
                    }
                    else
                    {
                        isOk = false;
                    }
                    
                }
                catch (Exception ex)
                {
                    isOk = false;
                }

                return isOk;
            }
        }

        public bool DeleteArticlo(int id)
        {
            bool isOk = true;

            using (TPVContext context = new TPVContext())
            {
                try
                {
                    context.Articulos.Remove(context.Articulos.Where(it => it.Id == id).FirstOrDefault());
                }
                catch (Exception ex)
                {
                    isOk = false;
                }

                return isOk;
            }
        }

        public bool DeleteArticuloByCodigo(string codigo)
        {
            bool isOk = true;

            using (TPVContext context = new TPVContext())
            {
                try
                {
                    context.Articulos.Remove(context.Articulos.Where(it => it.Codigo == codigo).FirstOrDefault());
                }
                catch (Exception ex)
                {
                    isOk = false;
                }

                return isOk;
            }
        }
    }
}
