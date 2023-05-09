namespace BookKeeping.Models
{
    public class Credit
    {
        public Guid Id { get; set; }

        public decimal? CrAmt { get; set; }

        public Guid GeneralJournalId { get; set; }

        public Guid CrAccId { get; set; }

        public Guid CrAccCatId { get; set; }

        public virtual GeneralJournal GeneralJournal { get; set; }
    }
}
