namespace BackendProyectoTienda.DTO
{
    public class Wrapper
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public Dictionary<string,Object> Data { get; set; }
    }
}
