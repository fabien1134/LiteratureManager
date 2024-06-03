using LiteratureManagementApi.Data;
using LiteratureManagementApi.Dtos;
using LiteratureManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LiteratureManagementApi.Repository
{
    public class LiteratureRepository(DataContext context) : IRepository<Book>
    {
        private readonly DataContext _context = context;

        public async Task<List<Book>> GetAllRecordsAsync() => await _context.Books.AsNoTracking()
               .Include(book => book.BookCategories)
               .ThenInclude(bookCategory => bookCategory.Category)
               .ToListAsync();

        public async Task UpdateRecordAsync(UpdateBookDetailsDto updateBookDetailsDto)
        {
            var existingBook = await _context.Books.FirstOrDefaultAsync(b => b.Id == updateBookDetailsDto.Id) ?? throw new Exception("Not found book with provided bookId");
            existingBook.ISBN = updateBookDetailsDto.ISBN;
            existingBook.Title = updateBookDetailsDto.Title;
            existingBook.Description = updateBookDetailsDto.Description;
            existingBook.IsAvailable = updateBookDetailsDto.IsAvailable;
            await _context.SaveChangesAsync();
        }
    }
}
