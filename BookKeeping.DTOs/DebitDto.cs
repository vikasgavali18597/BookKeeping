namespace BookKeeping.DTOs
{
    public class DebitDto
    {
        public decimal DrAmt { get; set; }

        public Guid DrAccCatId { get; set; }

        public Guid DrAccId { get; set;}
    }
}
