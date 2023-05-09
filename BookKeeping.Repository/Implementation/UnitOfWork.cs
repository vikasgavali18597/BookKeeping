using BookKeeping.DataStore;
using BookKeeping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeping.Repository.Implementation
{
    public class UnitOfWork : IDisposable
    {
        private BookKeepingDbContext _context;

        public UnitOfWork(BookKeepingDbContext context)
        {
            _context = context;
        }


        private GenericRepository<AccountCategory> _accountCategoryRepository;
        private GenericRepository<Account> _accountRepository;
        private GenericRepository<GeneralJournal> _generalJournalRepository;
        public BookKeepingDbContext Context
        {
            get { return _context; }
        }

        public GenericRepository<GeneralJournal> generalJournalRepository
        {
            get
            {
                if (_generalJournalRepository == null)
                {
                    _generalJournalRepository = new GenericRepository<GeneralJournal>(_context);
                }

                return _generalJournalRepository;
            }
        }

        public GenericRepository<AccountCategory> accountCategoryRepository
        {
            get
            {

                if (this._accountCategoryRepository == null)
                {
                    this._accountCategoryRepository = new GenericRepository<AccountCategory>(_context);
                }
                return _accountCategoryRepository;
            }
        }

        public GenericRepository<Account> AccountRepository
        {
            get
            {
                if (_accountRepository ==  null)
                {
                    _accountRepository = new GenericRepository<Account>(_context);
                }

                return _accountRepository;
            }
        }


        public async Task Save()
        {
           await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
