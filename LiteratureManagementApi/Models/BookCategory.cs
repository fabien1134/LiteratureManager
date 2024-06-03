namespace LiteratureManagementApi.Models
{
    public class BookCategory
    {
        public required long Id { get; set; }
        public required long BookId { get; set; }
        public required long CategoryId { get; set; }

        public Book Book { get; set; }
        public Category Category { get; set; }
    }
}
