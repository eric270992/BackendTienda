using Newtonsoft.Json;

namespace BackendProyectoTienda.DTO
{
    public class DTOFamilia
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
