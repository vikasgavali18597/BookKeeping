using BookKeeping.DTOs;
using BookKeeping.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeping.Api.Controllers
{
    [Route("api/accountcategory")]
    [ApiController]
    public class AccountCategoryController : ControllerBase
    {
        private readonly IAccountCategoryService _accountCategoryService;
        public AccountCategoryController(IAccountCategoryService accountCategoryService)
        {
            _accountCategoryService = accountCategoryService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAccountCategory(AccountCategoryDto accountCategoryDto)
        {
            try
            {
                await _accountCategoryService.AddAccountCategory(accountCategoryDto);
                return Ok();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAccountCategories()
        {
            try
            {
                return Ok(await _accountCategoryService.GetAccountCategoriesAsync());
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAccountCategorie([FromRoute]Guid id)
        {
            try
            {
                return Ok(await _accountCategoryService.GetAccountCategory(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAccountCategory(AccountCategoryDto accountCategoryDto)
        {
            try
            {
                await _accountCategoryService.UpdateAccountCategory(accountCategoryDto);
                return Ok();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAccountCategory(Guid id)
        {
            try
            {
                await _accountCategoryService.DeleteAccountCatgeory(id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
