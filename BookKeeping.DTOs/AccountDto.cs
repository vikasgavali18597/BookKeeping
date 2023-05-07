namespace BookKeeping.DTOs
{
    public class AccountDto
    {
        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public string? Description { get; set; }

        public Guid AccountCategoryId { get; set; }
    }
}
