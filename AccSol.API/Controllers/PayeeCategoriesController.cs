
using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PayeeCategoriesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public PayeeCategoriesController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<PayeeCategory>> GetAll()
        {
            try
            {
                var list = _repository.PayeeCategory.GetAll(trackChanges: false);

                return Ok(list);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

        // GET: PayeeCategories/GetById/5
        [HttpPost("Get")]
        public ActionResult<PayeeCategory?> Get([FromBody] int? id)
        {
            try
            {
                PayeeCategory? payeeCategory = null;
                if (id != null)
                {
                    payeeCategory = _repository.PayeeCategory.Get(id, trackChanges: false);
                     
                }

                return Ok(payeeCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] PayeeCategory? payeeCategory)
        {
            try
            {
                if (payeeCategory != null)
                {
                    _repository.PayeeCategory.SavePayeeCategory(payeeCategory);

                }

                return Ok(payeeCategory);

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
                    var payeeCategory = _repository.PayeeCategory.Get(id, false);
                    if (payeeCategory != null) 
                    {
                        _repository.PayeeCategory.DeletePayeeCategory(payeeCategory);
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
