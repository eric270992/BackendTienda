using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.Utils
{
    public static class UtilsFamilia
    {
        public static DTOFamilia ConvertirFamiliaToDTO(Familia familia)
        {
            DTOFamilia dtoFamilia = new DTOFamilia();
            dtoFamilia.Id = familia.Id;
            dtoFamilia.Nombre = familia.Nombre;

            return dtoFamilia;
        }

        public static List<DTOFamilia> ConvertirListFamiliaToDTO(List<Familia> list)
        {
            List<DTOFamilia> listDTO = new List<DTOFamilia>();

            list.ForEach(item => { 
                listDTO.Add(ConvertirFamiliaToDTO(item));
            });

            return listDTO;
        }

        public static Familia ConvertirDTOToFamilia(DTOFamilia dtoFamilia)
        {
            Familia familia = new Familia();
            familia.Id = dtoFamilia.Id;
            familia.Nombre = dtoFamilia.Nombre;

            return familia;
        }

        public static List<Familia> ConvertirListDTOToListFamilia(List<DTOFamilia> listDTO)
        {
            List<Familia> list = new List<Familia>();

            listDTO.ForEach(item => {
                list.Add(ConvertirDTOToFamilia(item));
            });

            return list;
        }


    }
}
