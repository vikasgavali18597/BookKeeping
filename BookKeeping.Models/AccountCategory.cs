namespace BookKeeping.Models
{
    public class AccountCategory
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public string? Description { get; set; }
        
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
