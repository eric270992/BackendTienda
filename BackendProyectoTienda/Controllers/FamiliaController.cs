using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
        public Wrapper GetAll()
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                wrapper.Message = "Dades recuperades correctament";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    {"Dades",_repoFamilia.GetAll()}
                };
            }
            catch(Exception err)
            {
                wrapper.Message = "Error recuperant dades";
                wrapper.Status = "500";
            }
            return wrapper;
        }

        [HttpGet("nombre/{nombre}")]
        public Wrapper GetAllByLikeNombre(string nombre)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                wrapper.Message = "Dades recuperades correctament";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    {"Dades",_repoFamilia.GetAllByName(nombre)}
                };
            }
            catch (Exception err)
            {
                wrapper.Message = "Error recuperant dades";
                wrapper.Status = "500";
            }
            return wrapper;
        }

        [HttpGet("id/{id}")]
        public Wrapper GetById(int id)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                wrapper.Message = "Dades recuperades correctament";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    {"Dades",_repoFamilia.GetById(id)}
                };
            }
            catch (Exception err)
            {
                wrapper.Message = "Error recuperant dades";
                wrapper.Status = "500";
            }
            return wrapper;
        }

        [HttpPost]
        public Wrapper Post([FromBody] DTOFamilia dTOFamilia)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                if (_repoFamilia.PostFamilia(dTOFamilia))
                {
                    wrapper.Message = "EXIT EN GUARDAR FAMILIA";
                    wrapper.Status = "200";
                }
            }
            catch (Exception err)
            {
                wrapper.Message = "ERROR GUARDANT FAMILIA AL CONTROLLER";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpPut]
        public Wrapper Put([FromBody] DTOFamilia dto)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                if (_repoFamilia.PutFamilia(dto))
                {
                    wrapper.Message = "EXIT EN ACTUALITZAR FAMILIA";
                    wrapper.Status = "200";
                }
            }
            catch (Exception err)
            {
                wrapper.Message = "ERROR ACTUALITZANT FAMILIA AL CONTROLLER";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpDelete("{id}")]
        public Wrapper Delete(int id)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                if (_repoFamilia.DeleteFamilia(id))
                {
                    wrapper.Message = "EXIT EN ELIMINAR FAMILIA";
                    wrapper.Status = "200";
                }
            }
            catch (Exception err)
            {
                wrapper.Message = "ERROR ELIMINANT FAMILIA AL CONTROLLER";
                wrapper.Status = "500";
            }

            return wrapper;
        }
    }
}
