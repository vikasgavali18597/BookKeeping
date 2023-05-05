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
        }
    }
}
