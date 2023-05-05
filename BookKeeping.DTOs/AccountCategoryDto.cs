namespace BookKeeping.DTOs
{
    public class AccountCategoryDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public string? Description { get; set; }
    }
}
