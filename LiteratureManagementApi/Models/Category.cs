namespace LiteratureManagementApi.Models
{
    public class Category
    {
        public required long Id { get; set; } 

        public required string CategoryName { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
