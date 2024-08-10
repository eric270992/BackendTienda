using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using BackendProyectoTienda.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendProyectoTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubfamiliaController : ControllerBase
    {
        private RepositorySubfamilia _repositorySubfamilia;
        public SubfamiliaController(RepositorySubfamilia repositorySubfamilia) {
            _repositorySubfamilia = repositorySubfamilia;
        }

        [HttpGet]
        public Wrapper GetAll()
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                List<DTOSubfamilia> list = _repositorySubfamilia.GetAll();
                wrapper.Message = "Exit recuperant subfamilies";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    {
                        "Dades",list
                    }
                };
            }
            catch (Exception ex)
            {
                wrapper.Message = "ERROR recuperant subfamilies";
                wrapper.Status = "200";
            }

            return wrapper;
        }

        //Sempre ho podem passar sinó FromQuery
        [HttpGet("name/{name}")]
        public Wrapper GetAllByLikeName(string name)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                List<DTOSubfamilia> list = _repositorySubfamilia.GetByLikeName(name);
                wrapper.Message = "Exit recuperant subfamilies";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    {
                        "Dades",list
                    }
                };
            }
            catch (Exception ex)
            {
                wrapper.Message = "ERROR recuperant subfamilies";
                wrapper.Status = "200";
            }

            return wrapper;
        }

        [HttpGet("id/{id}")]
        public Wrapper GetById(int id)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                DTOSubfamilia subFamilia = _repositorySubfamilia.GetById(id);
                wrapper.Message = "Exit recuperant subfamilies";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    {
                        "Dades",subFamilia
                    }
                };
            }
            catch (Exception ex)
            {
                wrapper.Message = "ERROR recuperant subfamilies";
                wrapper.Status = "200";
            }

            return wrapper;
        }




        [HttpPost]
        public Wrapper Post(DTOSubfamilia dTOSubfamilia)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                _repositorySubfamilia.PostSubfamilia(dTOSubfamilia);
                wrapper.Message = "Exit afegint subfamilia";
                wrapper.Status = "200";
            }
            catch (Exception e)
            {
                wrapper.Message = "ERROR afegint subfamilia";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpPut]
        public Wrapper Put(DTOSubfamilia dTOSubfamilia)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                _repositorySubfamilia.PutSubfamilia(dTOSubfamilia);
                wrapper.Message = "Exit actualitzant subfamilia";
                wrapper.Status = "200";
            }
            catch (Exception e)
            {
                wrapper.Message = "ERROR actualitzant subfamilia";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpDelete]
        public Wrapper Delete(int id)
        {
            Wrapper wrapper = new Wrapper();
            try
            {
                _repositorySubfamilia.DeleteSubfamilia(id);
                wrapper.Message = "Exit eliminant subfamilia";
                wrapper.Status = "200";
            }
            catch (Exception e)
            {
                wrapper.Message = "ERROR eliminant subfamilia";
                wrapper.Status = "500";
            }

            return wrapper;
        }
    }
}
