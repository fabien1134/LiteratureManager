using LiteratureManagementApi.Data;
using LiteratureManagementApi.Dtos;
using LiteratureManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LiteratureManagementApi.Repository
{
    public class AuthorRepository(DataContext context) : IAuthorRepository
    {
        private readonly DataContext _context = context;

        public async Task AddNewAuthorAsync(NewAuthorDto newAuthorDto)
        {
            await _context.Authors.AddAsync(new Author
            {
                Name = newAuthorDto.Name,
                Biography = newAuthorDto.Biography,
                DateOfBirth = newAuthorDto.DateOfBirth,
            });

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAuthorAsync(long authorId)
        {

            var bookAuthors= await _context.BookAuthors.Where(ba=>ba.AuthorId==authorId).ToListAsync();
            if (bookAuthors.Any())
            {
                _context.BookAuthors.RemoveRange(bookAuthors);
                await _context.SaveChangesAsync();
            }

            var author = await _context.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
            if (author != null)
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
            }
        }
    }
}
