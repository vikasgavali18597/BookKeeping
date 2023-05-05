using AutoMapper;
using BookKeeping.DTOs;
using BookKeeping.Models;
using BookKeeping.Repository.Interfaces;
using BookKeeping.Services.Interfaces;

namespace BookKeeping.Services.Implementation
{
    public class AccountCategoryService : IAccountCategoryService
    {
        private readonly IAccountcategoryRepository _accountcategoryRepository;
        private readonly IMapper _mapper;
        public AccountCategoryService(IAccountcategoryRepository accountcategoryRepository, IMapper mapper)
        {
            _accountcategoryRepository = accountcategoryRepository;
            _mapper = mapper;
        }
        public async Task AddAccountCategory(AccountCategoryDto categoryDto)
        {
            var AccountCategory = new AccountCategory
            {
                Name =   categoryDto.Name,
                ShortName = categoryDto.ShortName,
                Description = categoryDto.Description,
            };
            await _accountcategoryRepository.AddAccountCategoryAsync(AccountCategory);
        }

        public async Task<AccountCategoryDto> GetAccountCategory(Guid id)
        {
            var accountCategory = await _accountcategoryRepository.GetByIdAsync(id); 
            return _mapper.Map<AccountCategoryDto>(accountCategory);
        }

        public async Task<IEnumerable<AccountCategoryDto>> GetAccountCategoriesAsync()
        {
            var accountCategories = await _accountcategoryRepository.GetAccountCategoriesAsync();
            return accountCategories.Select(x => _mapper.Map<AccountCategoryDto>(x));
        }

        public async Task UpdateAccountCategory(AccountCategoryDto accountCategoryDto)
        {
            var accountCategory = _mapper.Map<AccountCategory>(accountCategoryDto);
            await _accountcategoryRepository.UpdateAsync(accountCategory);
        }

        public async Task DeleteAccountCatgeory(Guid id)
        {
            await _accountcategoryRepository.DeleteAsync(id);
        }
    }
}
