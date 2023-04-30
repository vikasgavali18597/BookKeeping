using BookKeeping.Models;
using BookKeeping.Repository.Implementation;

namespace BookKeeping.Repository.Interfaces
{
    public interface IAccountcategoryRepository
    {
        Task<bool> AddAccountCategoryAsync(AccountCategory accountCategory);

        Task<AccountCategory> GetByIdAsync(Guid id);

        Task<IEnumerable<AccountCategory>> GetAccountCategoriesAsync();

        Task<bool> UpdateAsync(AccountCategory accountCategory);

        Task<bool> DeleteAsync(Guid id);
    }
}
