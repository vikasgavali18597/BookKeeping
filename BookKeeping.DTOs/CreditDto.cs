namespace BookKeeping.DTOs
{
    public class CreditDto
    {
        public decimal CrAmt { get; set; }

        public Guid CrAccCatId { get; set; }

        public Guid CrAccId { get; set; }
    }
}
