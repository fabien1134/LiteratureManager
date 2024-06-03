namespace LiteratureManagementApi.Models
{
    public class BookImage
    {
        public required long Id { get; set; }
        public required long BookId { get; set; }
        public required long ImageId { get; set; }
    }
}
