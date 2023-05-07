using AutoMapper;
using BookKeeping.DTOs;
using BookKeeping.Models;
using BookKeeping.Repository.Implementation;
using BookKeeping.Services.Interfaces;

namespace BookKeeping.Services.Implementation
{
    public class AccountService : IAccountService
    {

        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccountService(UnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    
        public async Task<bool> DeleteAccountAsync(Guid id)
        {
            await _unitOfWork.AccountRepository.Delete(id);
            await _unitOfWork.Save();
            return true;

        }

        public async Task<AccountDto> GetAccountByIdAsync(Guid id)
        {
            var account = await _unitOfWork.AccountRepository.GetByID(id);
            return _mapper.Map<AccountDto>(account);

        }

        public async Task<IEnumerable<AccountDto>> GetAllAccountsAsync()
        {
            var accounts = await _unitOfWork.AccountRepository.Get();
            return accounts.Select(x => _mapper.Map<AccountDto>(x));
        }

        public async Task<bool> InsertAccountAsync(AccountDto accountDto)
        {
            var account = _mapper.Map<Account>(accountDto);
            await _unitOfWork.AccountRepository.Insert(account);
            await _unitOfWork.Save();
            return true;
        }

        public async Task<bool> UpdateAccountAsync(AccountDto accountDto)
        {
            var account = _mapper.Map<Account>(accountDto);
            _unitOfWork.AccountRepository.Update(account);
            await _unitOfWork.Save();
            return true;
        }
    }
}
