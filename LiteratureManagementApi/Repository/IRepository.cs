using LiteratureManagementApi.Dtos;

namespace LiteratureManagementApi.Repository
{
    public interface IRepository<T> where T : class 
    {
        Task<List<T>> GetAllRecordsAsync();
        Task UpdateRecordAsync(UpdateBookDetailsDto updateBookDetailsDto);
    }
}
