using Microsoft.AspNetCore.Mvc;
using AccSol.Models;
using AccSol.Repositories;
using AccSol.ViewModels;
using AccSol.Excel;
using AccSol.Reports.ExcelFiles;
using AccSol.Common.Reports;
using NPOI.SS.Formula.Functions;

namespace AccSol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PettyCashesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public PettyCashesController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<PettyCash>> GetAll()
        {
            var list = _repository.PettyCash.GetAll(trackChanges: false);
           
            return Ok(list);
        }

        // GET: PettyCashes/GetById/5
        [HttpPost("Get")]
        public ActionResult<PettyCash?> Get([FromBody] int? id)
        {
            try
            {
                PettyCash? pettyCash = null;
                if (id != null)
                {
                    pettyCash = _repository.PettyCash.Get(id, trackChanges: false);
                     
                }

                return Ok(pettyCash);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("Save")]
        public ActionResult<PettyCash?> Save([FromBody] PettyCash? pettyCash)
        {
            try
            {
                if (pettyCash != null)
                {
                    _repository.PettyCash.SavePettyCash(pettyCash);

                }

                return Ok(pettyCash);

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
                    var pettyCash = _repository.PettyCash.Get(id, false);
                    if (pettyCash != null) 
                    {
                        _repository.PettyCash.DeletePettyCash(pettyCash);
                    }
                }

                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("DownloadExcelReport")]
        public ActionResult DownloadExcelReport(List<GroupedReportData<PettyCashSummaryReportVM>> groupedReports, string excelFilePath, string xlsUrl)
        {
            try
            {
                var reportTitle = "Petty Cash Summary Report";
                var excelFile = new PettyCashReplenishmentSummaryExcel(excelFilePath, reportTitle);
                excelFile.CreateExcelFromGroupReportsAsync(groupedReports).Wait();
                excelFile.Save().Wait();
                byte[] reportBytes = excelFile.WriteToMemoryStream().Result;

                var file = File(
                    fileContents: reportBytes,
                    contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    fileDownloadName: xlsUrl);

                return Ok(file);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
