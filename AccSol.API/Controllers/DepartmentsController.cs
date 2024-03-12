using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public DepartmentsController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Department>> GetAll()
        {
            var list = _repository.Department.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: Departments/GetById/5
        [HttpGet("Get/{id}")]
        public ActionResult<Department?> Get(int id)
        {
            try
            {
                Department? department = _repository.Department.Get(id, trackChanges: false);
                return Ok(department);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] Department? department)
        {
            try
            {
                if (department != null)
                {
                    _repository.Department.SaveDepartment(department);
                }

                return Ok(department);

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
                    var department = _repository.Department.Get(id, false);
                    if (department != null) 
                    {
                        _repository.Department.DeleteDepartment(department);
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
