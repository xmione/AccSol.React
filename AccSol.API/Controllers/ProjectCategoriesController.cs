using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectCategoriesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public ProjectCategoriesController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<ProjectCategory>> GetAll()
        {
            var list = _repository.ProjectCategory.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: ProjectCategories/GetById/5
        [HttpPost("Get")]
        public ActionResult<ProjectCategory?> Get([FromBody] int? id)
        {
            try
            {
                ProjectCategory? projectCategory = null;
                if (id != null)
                {
                    projectCategory = _repository.ProjectCategory.Get(id, trackChanges: false);
                     
                }

                return Ok(projectCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] ProjectCategory? projectCategory)
        {
            try
            {
                if (projectCategory != null)
                {
                    _repository.ProjectCategory.SaveProjectCategory(projectCategory);
                }

                return Ok(projectCategory);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] int? id)
        {
            try
            {
                if (id != null)
                {
                    var projectCategory = _repository.ProjectCategory.Get(id, false);
                    if (projectCategory != null) 
                    {
                        _repository.ProjectCategory.DeleteProjectCategory(projectCategory);
                    }
                }

                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
