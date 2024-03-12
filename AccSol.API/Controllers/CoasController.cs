using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoasController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public CoasController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Coa>> GetAll()
        {
            var list = _repository.Coa.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: Coas/GetById/5
        [HttpPost("Get")]
        public ActionResult<Coa?> Get([FromBody] int? id)
        {
            try
            {
                Coa? coa = null;
                if (id != null)
                {
                    coa = _repository.Coa.Get(id, trackChanges: false);
                     
                }

                return Ok(coa);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] Coa? coa)
        {
            try
            {
                if (coa != null)
                {
                    _repository.Coa.SaveCoa(coa);

                }

                return Ok(coa);

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
                    var coa = _repository.Coa.Get(id, false);
                    if (coa != null) 
                    {
                        _repository.Coa.DeleteCoa(coa);
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
