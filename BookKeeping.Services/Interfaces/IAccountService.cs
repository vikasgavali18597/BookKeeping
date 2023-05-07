using BookKeeping.DTOs;
using BookKeeping.Models;

namespace BookKeeping.Services.Interfaces
{
    public interface IAccountService
    {
        Task<bool> InsertAccountAsync(AccountDto accountDto);

        Task<bool> UpdateAccountAsync(AccountDto accountDto);

        Task<bool> DeleteAccountAsync(Guid id);

        Task<AccountDto> GetAccountByIdAsync(Guid id);

        Task<IEnumerable<AccountDto>> GetAllAccountsAsync();
    }
}
