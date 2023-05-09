using BookKeeping.DTOs;

namespace BookKeeping.Services.Interfaces
{
    public interface IGeneralJournalService
    {
        Task AddGeneralJournal(GeneralJournalDto generalJournalDto);

        Task<GeneralJournalDto> GetGeneralJournal(Guid id);

        Task<IEnumerable<GeneralJournalDto>> GetGeneralJournalAsync(DateTime fromdate, DateTime toDate);

        Task UpdateGeneralJournal(GeneralJournalDto generalJournalDto);

        Task DeleteGeneralJournal(Guid id);
    }
}
