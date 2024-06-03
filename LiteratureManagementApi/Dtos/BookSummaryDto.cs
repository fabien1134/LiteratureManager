
namespace LiteratureManagementApi.DTO
{
    public class BookSummaryDto
    {
        public required long Id { get; set; }
        public required string Title { get; set; }
        public required string ISBN { get; set; }
        public required string Description { get; set; }
        public required DateTime PublicationDate { get; set; }
        public required bool IsAvailable { get; set; }
        public required List<string> CategoryNames { get; set; }
    }
}
