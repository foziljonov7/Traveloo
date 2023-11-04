using API.Data;
using API.Dtos;
using API.Entities;

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

        public Task<Ticket> GetTicket(int ticketId)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTickets()
        {
            throw new NotImplementedException();
        }
    }
}
