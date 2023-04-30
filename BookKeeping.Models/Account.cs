namespace BookKeeping.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public string? Description { get; set; }

        public Guid AccountCategoryId { get; set; }

        public virtual AccountCategory AccountCategoryCategory { get; set; }
    }
}
