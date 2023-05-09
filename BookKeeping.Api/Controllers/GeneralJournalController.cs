using BookKeeping.DataStore;
using BookKeeping.DTOs;
using BookKeeping.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeping.Api.Controllers
{
    [Route("api/generaljournal")]
    [ApiController]
    public class GeneralJournalController : ControllerBase
    {
        private readonly IGeneralJournalService _generalJournalService;

        public GeneralJournalController(IGeneralJournalService generalJournalService)
        {
            _generalJournalService = generalJournalService;
        }


        [HttpPost]
        public async Task<IActionResult> AddGeneralJournlas(GeneralJournalDto generalJournalDto)
        {
            try
            {
                await _generalJournalService.AddGeneralJournal(generalJournalDto);
                return Ok();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IEnumerable<GeneralJournalDto>> GetAllGeneralJournals(DateTime fromDate, DateTime toDate)
        {
            try
            {

               return await _generalJournalService.GetGeneralJournalAsync(fromDate, toDate);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
