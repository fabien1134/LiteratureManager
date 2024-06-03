using LiteratureManagementApi.Dtos;
using LiteratureManagementApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LiteratureManagementApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AuthorController(IAuthorService iAuthorService) : ControllerBase
    {
        private readonly IAuthorService _IAuthorService = iAuthorService;

        [HttpPost]
        public async Task AddNewAuthor(NewAuthorDto newAuthorDto) => await _IAuthorService.AddNewAuthorAsync(newAuthorDto);

        [HttpDelete]
        public async Task DeleteAuthor(long authorId) => await _IAuthorService.DeleteAuthorAsync(authorId);
    }
}
