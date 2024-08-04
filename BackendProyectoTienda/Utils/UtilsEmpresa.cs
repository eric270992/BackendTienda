using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.Utils
{
    public static class UtilsEmpresa
    {
        public static DTOEmpresa ConvertirEmpresaToDtoEmpresa(Empresa empresa)
        {
            DTOEmpresa dtoEmpresa = new DTOEmpresa();
            dtoEmpresa.Id = empresa.Id;
            dtoEmpresa.Nombre = empresa.Nombre;
            dtoEmpresa.Direccion = empresa.Direccion;
            dtoEmpresa.Telefono = empresa.Telefono;
            dtoEmpresa.Email = empresa.Email;
            dtoEmpresa.Nif = empresa.Nif;

            return dtoEmpresa;
        }

        public static List<DTOEmpresa> ConvertiListEmpresaToListDTOEmpresa(List<Empresa> listEmpresa)
        {
            List<DTOEmpresa> llistaDTO = new List<DTOEmpresa>();
            foreach (Empresa item in listEmpresa)
            {
                llistaDTO.Add(ConvertirEmpresaToDtoEmpresa(item));
            }

            return llistaDTO;
        }

        public static Empresa ConvertirDtoEmpresaToEmpresa(DTOEmpresa dtoEmpresa)
        {
            Empresa empresa = new Empresa();
            empresa.Id = dtoEmpresa.Id;
            empresa.Nombre = dtoEmpresa.Nombre;
            empresa.Direccion = dtoEmpresa.Direccion;
            empresa.Telefono = dtoEmpresa.Telefono;
            empresa.Email = dtoEmpresa.Email;
            empresa.Nif = dtoEmpresa.Nif;

            return empresa;
        }

        public static List<Empresa> ConvertiListDtoEmpresaToListEmpresa(List<DTOEmpresa> listDtoEmpresa)
        {
            List<Empresa> llistaEmpresa = new List<Empresa>();
            foreach (DTOEmpresa item in listDtoEmpresa)
            {
                llistaEmpresa.Add(ConvertirDtoEmpresaToEmpresa(item));
            }

            return llistaEmpresa;
        }
    }
}
