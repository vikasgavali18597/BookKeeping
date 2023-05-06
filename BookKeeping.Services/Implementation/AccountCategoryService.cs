using AutoMapper;
using BookKeeping.DTOs;
using BookKeeping.Models;
using BookKeeping.Repository.Implementation;
using BookKeeping.Services.Interfaces;

namespace BookKeeping.Services.Implementation
{
    public class AccountCategoryService : IAccountCategoryService
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        public AccountCategoryService(IMapper mapper, UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAccountCategory(AccountCategoryDto categoryDto)
        {
            var accountCategory = _mapper.Map<AccountCategory>(categoryDto);

            await _unitOfWork.accountCategoryRepository.Insert(accountCategory);
            await _unitOfWork.Save();
        }

        public async Task<AccountCategoryDto> GetAccountCategory(Guid id)
        {
            var accountCategory = await _unitOfWork.accountCategoryRepository.GetByID(id); 
            return _mapper.Map<AccountCategoryDto>(accountCategory);
        }

        public async Task<IEnumerable<AccountCategoryDto>> GetAccountCategoriesAsync()
        {
            var accountCategories = await _unitOfWork.accountCategoryRepository.Get();
            return accountCategories.Select(x => _mapper.Map<AccountCategoryDto>(x));
        }

        public async Task UpdateAccountCategory(AccountCategoryDto accountCategoryDto)
        {
            var accountCategory = _mapper.Map<AccountCategory>(accountCategoryDto);
            _unitOfWork.accountCategoryRepository.Update(accountCategory);
            await _unitOfWork.Save();
        }

        public async Task DeleteAccountCatgeory(Guid id)
        {
            await _unitOfWork.accountCategoryRepository.Delete(id);
            await _unitOfWork.Save();
        }
    }
}
