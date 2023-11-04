using API.Dtos;
using API.Services;
using API.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        private readonly IHumanService service;

        public HumanController(IHumanService service)
        {
            this.service = service;    
        }

        [HttpPost("Create")]
        [ValidationActionFilter]
        public async Task<IActionResult> CreateHuman([FromBody] CreateHumanDto dto)
        {
            await service.CreateHuman(dto);
            return Ok(dto);
        }

        [HttpGet("GetHumans")]
        public async Task<IActionResult> GetHumans()
        {
            return Ok(await service.GetHumans());
        }
        [HttpGet("GetHuman/{id}")]
        public async Task<IActionResult> GetHuman([FromRoute] Guid id)
        {
            return Ok(await service.GetHuman(id));
        }
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> EditHuman(
            [FromRoute] Guid id,
            [FromBody] EditHumanDto dto)
        {
            return Ok(await service.EditHuman(id, dto));
        }
        [HttpDelete("Remove/{id}")]
        public async Task<IActionResult> RemoveHuman(Guid id)
        {
            return Ok(await service.DeleteHuman(id));
        }
    }
}
