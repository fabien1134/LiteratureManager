using LiteratureManagementApi.DTO;
using LiteratureManagementApi.Dtos;
using LiteratureManagementApi.Models;
using LiteratureManagementApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LiteratureManagementApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LiteratureController(ILiteratureService<Book> iLiteratureService) : ControllerBase
    {
        private readonly ILiteratureService<Book> _ILiteratureService = iLiteratureService;

        [HttpGet]
        public async Task<List<BookSummaryDto>> GetBooks() => await _ILiteratureService.GetAllRecordsAsync();

        [HttpPut]
        public async Task UpdateBook(UpdateBookDetailsDto updateBookDetailsDto) => await _ILiteratureService.UpdateBookDetailsAsync(updateBookDetailsDto);

    }
}
