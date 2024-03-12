using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public ClientsController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Client>> GetAll()
        {
            try
            {
                var list = _repository.Client.GetAll(trackChanges: false);

                return Ok(list);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

        // GET: Clients/GetById/5
        [HttpPost("Get")]
        public ActionResult<Client?> Get([FromBody] int? id)
        {
            try
            {
                Client? client = null;
                if (id != null)
                {
                    client = _repository.Client.Get(id, trackChanges: false);
                     
                }

                return Ok(client);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] Client? client)
        {
            try
            {
                if (client != null)
                {
                    _repository.Client.SaveClient(client);

                }

                return Ok(client);

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
                    var client = _repository.Client.Get(id, false);
                    if (client != null) 
                    {
                        _repository.Client.DeleteClient(client);
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
