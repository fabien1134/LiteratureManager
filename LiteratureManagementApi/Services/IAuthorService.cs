using LiteratureManagementApi.Dtos;

namespace LiteratureManagementApi.Services
{
    public interface IAuthorService
    {
        Task AddNewAuthorAsync(NewAuthorDto newAuthorDto);
        Task DeleteAuthorAsync(long authorId);
    }
}
