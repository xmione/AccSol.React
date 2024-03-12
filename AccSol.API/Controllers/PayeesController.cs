using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PayeesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public PayeesController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Payee>> GetAll()
        {
            var list = _repository.Payee.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: Payees/GetById/5
        [HttpPost("Get")]
        public ActionResult<Payee?> Get([FromBody] int? id)
        {
            try
            {
                Payee? payee = null;
                if (id != null)
                {
                    payee = _repository.Payee.Get(id, trackChanges: false);
                     
                }

                return Ok(payee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] Payee? payee)
        {
            try
            {
                if (payee != null)
                {
                    _repository.Payee.SavePayee(payee);
                }

                return Ok(payee);

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
                    var payee = _repository.Payee.Get(id, false);
                    if (payee != null) 
                    {
                        _repository.Payee.DeletePayee(payee);
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
