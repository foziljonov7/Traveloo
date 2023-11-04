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

        [HttpPost]
        [ValidationActionFilter]
        public async Task<IActionResult> CreateHuman(CreateHumanDto dto)
        {
            await service.CreateHuman(dto);
            return Ok(dto);
        }
    }
}
