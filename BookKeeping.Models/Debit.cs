namespace BookKeeping.Models
{
    public class Debit
    {
        public Guid Id { get; set; }

        public string? GlNo { get; set; }

        public DateTime Date { get; set; }

        public decimal? DrAmt { get; set; }

        public Guid GeneralJournalId { get; set; }

        public Guid DrAccId { get; set; }

        public Guid DrAccCatId { get; set; }


        public virtual GeneralJournal GeneralJournal { get; set; }
    }
}
