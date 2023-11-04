using API.Dtos;
using API.Entities;

namespace API.Services
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetTickets();
        Task<Ticket> GetTicket(int ticketId);
        Task<Ticket> CreateTicket(CreateTicketDto dto);
    }
}
