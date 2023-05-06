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
        private BookKeepingDbContext context;

        public UnitOfWork(BookKeepingDbContext context)
        {
            this.context = context;
        }


        private GenericRepository<AccountCategory> _accountCategoryRepository;
     

        public GenericRepository<AccountCategory> accountCategoryRepository
        {
            get
            {

                if (this._accountCategoryRepository == null)
                {
                    this._accountCategoryRepository = new GenericRepository<AccountCategory>(context);
                }
                return _accountCategoryRepository;
            }
        }

        
        public async Task Save()
        {
           await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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
