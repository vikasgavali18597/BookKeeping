using BookKeeping.Models;
using BookKeeping.Services.Implementation;
using BookKeeping.Services.Interfaces;

namespace BookKeeping.Api
{
    public static class Extenssion
    {
        public static IServiceCollection ServiceCollection(this IServiceCollection service, IServiceCollection services)
        {
            services.AddScoped<IAccountCategoryService, AccountCategoryService>();
            services.AddScoped<IAccountService, AccountService>();
            return services;
        }

        public static List<AccountCategory> GetAccountCategories(this IServiceCollection services)
        {
            var lst =  new List<AccountCategory>
            {
                new AccountCategory{ Name ="Current Assets", ShortName="CA", Description = "Current Account" },
                new AccountCategory{ Name ="Fixed Assets", ShortName="FA", Description = "Fixed Account" },
                new AccountCategory{ Name ="Current Liability", ShortName="CL", Description = "Current Liability" },
                new AccountCategory{ Name ="Long Trum Liability", ShortName="LTL", Description = "Long Trum Liability Account" },
                new AccountCategory{ Name ="Owne Equity", ShortName="OE", Description = "Owne Equity Account" },
                new AccountCategory{ Name ="Cost Of Goods Sold", ShortName="CDS", Description = "Cost Of Goods Sold Account" },
                new AccountCategory{ Name ="Expenses", ShortName="Expense", Description = "Expenses Account" }
            };

            return lst;
        }
    }
}
