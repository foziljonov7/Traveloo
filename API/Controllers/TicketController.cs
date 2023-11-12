using API.Dtos;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService service;

        public TicketController(ITicketService service)
        {
            this.service = service;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateTicket(CreateTicketDto dto)
        {
            await service.CreateTicket(dto);
            return Ok(dto);
        }
        [HttpGet("Tickets")]
        public async Task<IActionResult> GetTickets()
        {
            return Ok(await service.GetTickets());
        }
        [HttpGet("GetTicket/{id}")]
        public async Task<IActionResult> GetTicket([FromRoute] int id)
        {
            return Ok(await service.GetTicket(id));
        }
    }
}
