using LiteratureManagementApi.DTO;
using LiteratureManagementApi.Dtos;

namespace LiteratureManagementApi.Services
{
    public interface ILiteratureService<T> where T : class
    {
        Task<List<BookSummaryDto>> GetAllRecordsAsync();
        Task UpdateBookDetailsAsync(UpdateBookDetailsDto updateBookDetailsDto);
    }
}
