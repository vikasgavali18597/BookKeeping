namespace BookKeeping.Models
{
    public class GeneralJournal
    {
        public Guid Id { get; set; }

        public string? GLNo { get; set; }

        public DateTime? Date { get; set; }

        public string? CrAccount { get; set; }

        public string? DrAccount { get; set; }

        public decimal DrAmt { get; set; }

        public decimal CrAmt { get; set; }

        public string? Narration { get; set; }

        public Guid DrActCategoryId { get; set; }

        public Guid CrActCategoryId { get; set; }

    }
}
