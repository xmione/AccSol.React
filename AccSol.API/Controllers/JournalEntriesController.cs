using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JournalEntriesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public JournalEntriesController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Journal>> GetAll()
        {
            var list = _repository.Journal.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: JournalEntries/GetById/5
        [HttpPost("Get")]
        public ActionResult<Journal?> Get([FromBody] int? id)
        {
            try
            {
                Journal? journalEntry = null;
                if (id != null)
                {
                    journalEntry = _repository.Journal.Get(id, trackChanges: false);
                     
                }

                return Ok(journalEntry);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] Journal? journal)
        {
            try
            {
                if (journal != null)
                {
                    _repository.Journal.SaveJournal(journal);
                }

                return Ok(journal);

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
                    var journal = _repository.Journal.Get(id, false);
                    if (journal != null) 
                    {
                        _repository.Journal.DeleteJournal(journal);
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
