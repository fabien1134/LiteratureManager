namespace LiteratureManagementApi.Dtos
{
    public class UpdateBookDetailsDto
    {
        public required long Id { get; set; }
        public required string Title { get; set; }
        public required string ISBN { get; set; }
        public required string Description { get; set; }
        public required bool IsAvailable { get; set; }
    }
}
