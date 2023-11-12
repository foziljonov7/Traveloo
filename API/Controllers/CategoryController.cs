using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }
        [HttpGet("Categorys")]
        public async Task<IActionResult> GetCategorys()
        {
            return Ok(await service.GetCategorys());
        }
        [HttpGet("Category/{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            return Ok(await service.GetCategory(id));
        }
        [HttpGet("Human/Category/{id}")]
        public async Task<IActionResult> GetHumanCategory(int id)
        {
            return Ok(await service.GetHumanCategory(id));
        }
    }
}
