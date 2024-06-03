namespace LiteratureManagementApi.Dtos
{
    public class NewAuthorDto
    {
        public required string Name { get; set; }
        public string? Biography { get; set; }
        public required DateTime DateOfBirth { get; set; }

    }
}
