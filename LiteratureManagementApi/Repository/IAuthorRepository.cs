using LiteratureManagementApi.Dtos;

namespace LiteratureManagementApi.Repository
{
    public interface IAuthorRepository
    {
        Task AddNewAuthorAsync(NewAuthorDto newAuthorDto);
        Task DeleteAuthorAsync(long authorId);
    }
}
