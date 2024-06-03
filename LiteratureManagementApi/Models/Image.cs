namespace LiteratureManagementApi.Models
{
    public class Image
    {
        public required long Id { get; set; }
        public required long ImageUrl { get; set; } //Should really be an azure blob storage location pointer
        public required DateTime LastUpdatedUtc { get; set; }
        public required DateTime CreatedDateUtc { get; set; }
    }
}
