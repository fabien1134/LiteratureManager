namespace LiteratureManagementApi.Models
{
    public class Review
    {
        public required long Id { get; set; }
        public required long BookId { get; set; }
        public required long Rating { get; set; }
        public required string Comment { get; set; }
        public required DateTime LastUpdatedUtc { get; set; }
        public required DateTime CreatedDateUtc { get; set; }
    }
}
