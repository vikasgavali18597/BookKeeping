using BookKeeping.Models;
using Microsoft.EntityFrameworkCore;

namespace BookKeeping.DataStore
{
    public class BookKeepingDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountCategory> AccountCategories { get; set; }

        public DbSet<GeneralJournal> GeneralJournals { get; set; }

        public DbSet<Debit> Debits { get; set; }

        public DbSet<Credit> Credits { get; set; }


        public BookKeepingDbContext(DbContextOptions<BookKeepingDbContext> options) :base(options)
        {
        }
    }
}
