namespace LiteratureManagementApi.Models
{
    public class BookAuthor
    {
        public required long Id { get; set; }
        public required long BookId { get; set; }
        public Book Book { get; set; }
        public required long AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
