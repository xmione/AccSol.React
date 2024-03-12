using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectCodesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public ProjectCodesController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<ProjectCode>> GetAll()
        {
            var list = _repository.ProjectCode.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: ProjectCodes/GetById/5
        [HttpPost("Get")]
        public ActionResult<ProjectCode?> Get([FromBody] int? id)
        {
            try
            {
                ProjectCode? projectCode = null;
                if (id != null)
                {
                    projectCode = _repository.ProjectCode.Get(id, trackChanges: false);
                     
                }

                return Ok(projectCode);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] ProjectCode? projectCode)
        {
            try
            {
                if (projectCode != null)
                {
                    _repository.ProjectCode.SaveProjectCode(projectCode);
                }

                return Ok(projectCode);

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
                    var projectCode = _repository.ProjectCode.Get(id, false);
                    if (projectCode != null) 
                    {
                        _repository.ProjectCode.DeleteProjectCode(projectCode);
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
