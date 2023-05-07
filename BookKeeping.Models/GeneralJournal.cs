namespace BookKeeping.Models
{
    public class GeneralJournal
    {
        public Guid Id { get; set; }

        public string? GLNo { get; set; }

        public DateTime? Date { get; set; }

        public string? Narration { get; set; }

        public virtual Debit Debit { get; set; }

        public virtual Credit Credit { get; set; }
    }
}
