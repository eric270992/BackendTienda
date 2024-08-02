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
    }
}
