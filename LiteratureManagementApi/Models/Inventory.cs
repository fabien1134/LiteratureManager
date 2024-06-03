namespace LiteratureManagementApi.Models
{
    public class Inventory
    {
        public required long Id { get; set; }
        public required long BookId { get; set; }
        public required long QuantityAvailable { get; set; }
        public required DateTime LastUpdatedUtc { get; set; }
        public required DateTime CreatedDateUtc { get; set; }
    }
}
