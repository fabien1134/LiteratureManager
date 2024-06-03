using LiteratureManagementApi.DTO;
using LiteratureManagementApi.Dtos;
using LiteratureManagementApi.Models;
using LiteratureManagementApi.Repository;

namespace LiteratureManagementApi.Services
{
    public class LiteratureService(IRepository<Book> bookRepository) : ILiteratureService<Book>
    {
        private readonly IRepository<Book> _bookRepository = bookRepository;

        public async Task<List<BookSummaryDto>> GetAllRecordsAsync()
            => (await _bookRepository.GetAllRecordsAsync()).Select(b => new BookSummaryDto
            {
                Id = b.Id,
                ISBN = b.ISBN,
                Description = b.Description,
                Title = b.Title,
                PublicationDate = b.PublicationDateUtc,
                IsAvailable = b.IsAvailable,
                CategoryNames=b.BookCategories.Select(bc=>bc.Category.CategoryName).ToList(),
            }).ToList();

        public async Task UpdateBookDetailsAsync(UpdateBookDetailsDto updateBookDetailsDto) 
            => await _bookRepository.UpdateRecordAsync(updateBookDetailsDto);
    }
}
