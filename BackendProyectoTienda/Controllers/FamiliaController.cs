using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendProyectoTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {
        private RepositoryFamilia _repoFamilia;

        public FamiliaController(RepositoryFamilia repoFamilia)
        {
            _repoFamilia = repoFamilia;
        }

        [HttpGet]
        public List<DTOFamilia> GetAll()
        {
            return _repoFamilia.GetAll();
        }

        [HttpGet("nombre/{nombre}")]
        public List<DTOFamilia> GetAllByLikeNombre(string nombre)
        {
            return _repoFamilia.GetAllByName(nombre);
        }

        [HttpGet("id/{id}")]
        public DTOFamilia GetById(int id)
        {
            return _repoFamilia.GetById(id);
        }

        [HttpPost]
        public string Post([FromBody] DTOFamilia dTOFamilia)
        {
            string message = "ERROR GUARDANT FAMILIA AL CONTROLLER";
            if (_repoFamilia.PostFamilia(dTOFamilia))
            {
                message = "EXIT EN GUARDAR FAMILIA";
            }
            return message;
        }

        [HttpPut]
        public string Put([FromBody] DTOFamilia dto)
        {
            string message = "ERROR ACTUALITZANT FAMILIA AL CONTROLLER";
            if (_repoFamilia.PutFamilia(dto))
            {
                message = "EXIT EN ACTUALITZAR FAMILIA";
            }
            return message;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string message = "ERROR ELIMINANT FAMILIA AL CONTROLLER";
            if (_repoFamilia.DeleteFamilia(id))
            {
                message = "EXIT EN ELIMINAR FAMILIA";
            }
            return message;
        }
    }
}
