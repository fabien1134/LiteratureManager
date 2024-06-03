namespace LiteratureManagementApi.Models
{
    public class Author
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public string? Biography { get; set; }
        public required DateTime DateOfBirth { get; set; }
    }
}
