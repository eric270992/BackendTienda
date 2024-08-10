using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Models;

namespace BackendProyectoTienda.Utils
{
    public class UtilsSubfamilia
    {
        public static DTOSubfamilia ConvertirSubfamiliaToDTO(Subfamilia familia)
        {
            DTOSubfamilia dtoSubfamilia = new DTOSubfamilia();
            dtoSubfamilia.Id = familia.Id;
            dtoSubfamilia.Nombre = familia.Nombre;

            return dtoSubfamilia;
        }

        public static List<DTOSubfamilia> ConvertirListSubFamiliaToDTO(List<Subfamilia> list)
        {
            List<DTOSubfamilia> listDTO = new List<DTOSubfamilia>();

            list.ForEach(item =>
            {
                listDTO.Add(ConvertirSubfamiliaToDTO(item));
            });

            return listDTO;
        }

        public static Subfamilia ConvertirDTOToSubfamilia(DTOSubfamilia dtoSubfamilia)
        {
            Subfamilia subfamilia = new Subfamilia();
            subfamilia.Id = dtoSubfamilia.Id;
            subfamilia.Nombre = dtoSubfamilia.Nombre;

            return subfamilia;
        }

        public static List<Subfamilia> ConvertirListDTOToListSubfamilia(List<DTOSubfamilia> listDTO)
        {
            List<Subfamilia> list = new List<Subfamilia>();

            listDTO.ForEach(item => {
                list.Add(ConvertirDTOToSubfamilia(item));
            });

            return list;
        }

    }
}
