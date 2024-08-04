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

        public bool PostEmpresa(Empresa empresa)
        {
            bool isOk = true;
            using (TPVContext context = new TPVContext())
            {
                try
                {
                    context.Empresas.Add(empresa);
                }
                catch (Exception ex)
                {
                    isOk = false;
                }
                return isOk;
            }
        }

        public bool UpdateEmpresa(Empresa empresa)
        {
            bool isOk = false;

            using (TPVContext context = new TPVContext())
            {
                try
                {
                    Empresa empresaToUpdate = context.Empresas.Where(it => it.Id == empresa.Id).FirstOrDefault();

                    if (empresaToUpdate != null) { 
                        empresaToUpdate.Nombre = empresa.Nombre;
                        empresaToUpdate.Direccion = empresa.Direccion;
                        empresaToUpdate.Email = empresa.Email;
                        empresaToUpdate.Telefono = empresa.Telefono;
                        empresaToUpdate.Nif = empresa.Nif;

                        context.Empresas.Update(empresaToUpdate);
                        isOk = true;
                    }
                }
                catch (Exception err)
                {

                }

                return isOk;
            }
        }

        public bool DeleteEmpresa(int id)
        {
            bool isOk = false;
            using(TPVContext context = new TPVContext())
            {
                Empresa empresa = context.Empresas.Where(it => it.Id == id).FirstOrDefault();
                if(empresa != null)
                {
                    context.Empresas.Remove(empresa);
                    isOk = true;
                }
            }
        }

    }
}
