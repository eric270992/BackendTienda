using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using BackendProyectoTienda.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendProyectoTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        RepositoryEmpresa _repoEmpresa;
        public EmpresaController(RepositoryEmpresa repoEmpresa) 
        {
            _repoEmpresa = repoEmpresa;
        }

        [HttpGet("{id}")]
        public DTOEmpresa GetEmpresaById(int id)
        {
            return _repoEmpresa.GetEmpresaById(id);
        }

        [HttpGet]
        public Wrapper GetEmpreses()
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                wrapper.Data.Add("Empreses", _repoEmpresa.GetEmpreses());
                wrapper.Status = "200";
                wrapper.Message = "Empreses recuperades correctament";
            }
            catch (Exception ex)
            {
                wrapper.Status = "500";
                wrapper.Message = "Error recuperant empreses";
            }

            return wrapper;

        }
    }
}
