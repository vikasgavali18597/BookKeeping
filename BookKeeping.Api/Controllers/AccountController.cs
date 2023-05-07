using BookKeeping.DTOs;
using BookKeeping.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeping.Api.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;   
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAccount([FromRoute]Guid id)
        {
            try
            {
                return Ok(await _accountService.GetAccountByIdAsync(id));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                return Ok(await _accountService.GetAllAccountsAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> InsertAccount(AccountDto accountDto)
        {
            try
            {
                await _accountService.InsertAccountAsync(accountDto);
                return Ok(200);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAccount(AccountDto accountDto)
        {
            try
            {
                await _accountService.UpdateAccountAsync(accountDto);
                return Ok(200);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteAccount(Guid id)
        {
            try
            {
                await _accountService.DeleteAccountAsync(id);
                return Ok(200);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
