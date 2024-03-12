using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public EmployeesController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            var list = _repository.Employee.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: Employees/GetById/5
        [HttpPost("Get")]
        public ActionResult<Employee?> Get([FromBody] int? id)
        {
            try
            {
                Employee? employee = null;
                if (id != null)
                {
                    employee = _repository.Employee.Get(id, trackChanges: false);
                     
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] Employee? employee)
        {
            try
            {
                if (employee != null)
                {
                    _repository.Employee.SaveEmployee(employee);
                }

                return Ok(employee);

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
                    var employee = _repository.Employee.Get(id, false);
                    if (employee != null) 
                    {
                        _repository.Employee.DeleteEmployee(employee);
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
