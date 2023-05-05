using BookKeeping.DTOs;
using BookKeeping.Services.Implementation;

namespace BookKeeping.Services.Interfaces
{
    public interface IAccountCategoryService
    {
        Task AddAccountCategory(AccountCategoryDto categoryDto);

        Task<AccountCategoryDto> GetAccountCategory(Guid id);

        Task<IEnumerable<AccountCategoryDto>> GetAccountCategoriesAsync();

        Task UpdateAccountCategory(AccountCategoryDto accountCategoryDto);

        Task DeleteAccountCatgeory(Guid id);
    }
}
