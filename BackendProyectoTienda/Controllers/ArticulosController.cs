using BackendProyectoTienda.DTO;
using BackendProyectoTienda.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendProyectoTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private RepositoryArticulo _repoArticulo;

        public ArticulosController(RepositoryArticulo repoArticulo)
        {
            this._repoArticulo = repoArticulo;
        }

        [HttpGet]
        public Wrapper GetAll()
        {
            Wrapper wrapper = new Wrapper();

            try
            {
                wrapper.Message = "Exit en recuperar els articles";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    { "Dades", _repoArticulo.GetAll() }
                };
            }
            catch (Exception ex)
            {
                wrapper.Message = "Error en recuperar els articles";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpGet("codi/{codi}")]
        public Wrapper GetAllByCodi(string codi)
        {
            Wrapper wrapper = new Wrapper();

            try
            {
                wrapper.Message = "Exit en recuperar els articles";
                wrapper.Status = "200";
                wrapper.Data = new Dictionary<string, object>
                {
                    { "Dades", _repoArticulo.GetArticuloByCodigo(codi) }
                };
            }
            catch (Exception ex)
            {
                wrapper.Message = "Error en recuperar els articles";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpPost]
        public Wrapper PostArticulo([FromBody] DTOArticulo dtoArticle)
        {
            Wrapper wrapper = new Wrapper();

            try
            {
                wrapper.Message = "Exit en afegir l'article";
                wrapper.Status = "200";
                _repoArticulo.PostArticulo(dtoArticle);
            }
            catch (Exception ex)
            {
                wrapper.Message = "Error en afegir l'article";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpPut]
        public Wrapper PutArticulo([FromBody] DTOArticulo dtoArticle)
        {
            Wrapper wrapper = new Wrapper();

            try
            {
                wrapper.Message = "Exit en actualitzar l'article";
                wrapper.Status = "200";
                _repoArticulo.PutArticulo(dtoArticle);
            }
            catch (Exception ex)
            {
                wrapper.Message = "Error en actualitzar l'article";
                wrapper.Status = "500";
            }

            return wrapper;
        }

        [HttpDelete("{codigo}")]
        public Wrapper DeleteArticulo(string codigo)
        {
            Wrapper wrapper = new Wrapper();

            try
            {
                wrapper.Message = "Exit en eliminar l'article";
                wrapper.Status = "200";
                _repoArticulo.DeleteArticuloByCodigo(codigo);
            }
            catch (Exception ex)
            {
                wrapper.Message = "Error en eliminar l'article";
                wrapper.Status = "500";
            }

            return wrapper;
        }
    }
}
