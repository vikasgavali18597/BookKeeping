using AutoMapper;
using BookKeeping.DTOs;
using BookKeeping.Models;
using BookKeeping.Repository.Implementation;
using BookKeeping.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BookKeeping.Services.Implementation
{
    public class GeneralJournalServices : IGeneralJournalService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GeneralJournalServices(UnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddGeneralJournal(GeneralJournalDto generalJournalDto)
        {
            var generalJournal = _mapper.Map<GeneralJournal>(generalJournalDto);

            await _unitOfWork.generalJournalRepository.Insert(generalJournal);
            await _unitOfWork.Save();
        }

        public Task DeleteGeneralJournal(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GeneralJournalDto>> GetGeneralJournalAsync(DateTime fromDate, DateTime toDate)
        {
            var includeProperties = "Debit,Credit";
            IQueryable<GeneralJournal> query = _unitOfWork.Context.GeneralJournals;
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty)/*.Where(x => x.Date <= fromDate && x.Date >= toDate)*/;
            }

            return query.Select(x => _mapper.Map<GeneralJournalDto>(x));
        }

        public Task<GeneralJournalDto> GetGeneralJournal(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGeneralJournal(GeneralJournalDto generalJournalDto)
        {
            throw new NotImplementedException();
        }
    }
}


