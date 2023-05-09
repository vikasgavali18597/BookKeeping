using AutoMapper;
using BookKeeping.DTOs;
using BookKeeping.Models;

namespace BookKeeping.Services.Profiles
{
    public class BookKeepingProfile : Profile
    {
        public BookKeepingProfile()
        {
            CreateMap<AccountCategory, AccountCategoryDto>().ReverseMap();
            CreateMap<AccountCategoryDto, AccountCategory>();


            CreateMap<Account, AccountDto>().ReverseMap();

            CreateMap<GeneralJournal, GeneralJournalDto>().ReverseMap();

            CreateMap<Debit, DebitDto>().ReverseMap();

            CreateMap<Credit, CreditDto>().ReverseMap();
        }
    }
}
