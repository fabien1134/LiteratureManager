using LiteratureManagementApi.Dtos;
using LiteratureManagementApi.Models;
using LiteratureManagementApi.Repository;

namespace LiteratureManagementApi.Services
{
    public class AuthorService(IAuthorRepository authorRepository) : IAuthorService
    {

        private readonly IAuthorRepository _authorRepository = authorRepository;
        public async Task AddNewAuthorAsync(NewAuthorDto newAuthorDto) => await _authorRepository.AddNewAuthorAsync(newAuthorDto);

        public async Task DeleteAuthorAsync(long authorId)
        {
            await _authorRepository.DeleteAuthorAsync(authorId);
        }
    }
}
