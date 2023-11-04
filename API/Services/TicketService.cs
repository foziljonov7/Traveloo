using API.Data;
using API.Dtos;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class TicketService : ITicketService
    {
        private readonly AppDbContext dbContext;
        public TicketService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Ticket> CreateTicket(CreateTicketDto dto)
        {
            var random = new Random();
            var created = dbContext.Tickets.Add(new Ticket
            {
                Id = random.Next(1000, 100000),
                Flight = dto.Flight,
                Price = dto.Price,
                Date = DateTime.UtcNow
            });

            await dbContext.SaveChangesAsync();

            return await Task.FromResult(created.Entity);
        }

        public async Task<Ticket> GetTicket(int ticketId)
        {
            var ticket = await dbContext.Tickets
                .Where(p => p.Id == ticketId)
                .FirstOrDefaultAsync();

            if (ticket is null)
                return null;

            return ticket;
        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            var tickets = await dbContext.Tickets.ToListAsync();

            return await Task.FromResult(tickets);
        }
    }
}
