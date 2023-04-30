﻿using BookKeeping.DataStore;
using BookKeeping.Models;
using BookKeeping.Repository.Interfaces;

namespace BookKeeping.Repository.Implementation
{
    public class AccountCategoryRepository : IAccountcategoryRepository
    {
        private readonly BookKeepingDbContext _context;
        public AccountCategoryRepository(BookKeepingDbContext context)
        {
            _context= context;
        }
        public async Task<bool> AddAccountCategoryAsync(AccountCategory accountCategory)
        {
            try
            {
                await _context.AccountCategories.AddAsync(accountCategory);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var accountCategory = await _context.AccountCategories.FindAsync(id);
            if (accountCategory != null)
            {
                _context.AccountCategories.Remove(accountCategory);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<AccountCategory>> GetAccountCategoriesAsync()
        {
            return _context.AccountCategories.ToList();
        }

        public async Task<AccountCategory> GetByIdAsync(Guid id)
        {
            var accountCategory =  await _context.AccountCategories.FindAsync(id);

            if (accountCategory == null )
            {
                return new AccountCategory();
            }

            return accountCategory;
        }

        public Task<bool> UpdateAsync(AccountCategory accountCategory)
        {
            throw new NotImplementedException();
        }
    }
}