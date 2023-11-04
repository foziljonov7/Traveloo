using API.Data;
using API.Dtos;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class HumanService : IHumanService
    {
        private readonly AppDbContext dbContext;

        public HumanService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;    
        }
        public async Task<Human> CreateHuman(CreateHumanDto dto)
        {
            var created = dbContext.Humans.Add(new Human
            {
                Id = Guid.NewGuid(),
                Firstname = dto.Firstname,
                Lastname = dto.Lastname,
                Age = dto.Age,
                PhoneNumber = dto.PhoneNumber,
                Location = dto.Location,
                CategoryId = dto.CategoryId,
                TicketId = dto.TicketId
            });

            await dbContext.SaveChangesAsync();
            return await Task.FromResult(created.Entity);
        }

        public async Task<bool> DeleteHuman(Guid id)
        {
            var human = await dbContext.Humans
                .FirstOrDefaultAsync(h => h.Id == id);

            if (human is null)
                return false;

            dbContext.Humans.Remove(human);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Human> EditHuman(Guid id, EditHumanDto dto)
        {
            var human = await dbContext.Humans
                .FirstOrDefaultAsync(h => h.Id == id);

            if (human is null)
                return null;

            human.Firstname = dto.Firstname;
            human.Lastname = dto.Lastname;
            human.Age = dto.Age;
            human.PhoneNumber = dto.PhoneNumber;
            human.Location = dto.Location;
            human.CategoryId = dto.CategoryId;

            await dbContext.SaveChangesAsync();
            return human;
        }

        public async Task<Human> GetHuman(Guid id)
        {
            var human = await dbContext.Humans
                .Where(h => h.Id == id)
                .Include(p => p.Category)
                .Include(p => p.Ticket)
                .FirstOrDefaultAsync();

            if (human is null)
                return null;
            
            return human;
        }

        public async Task<IEnumerable<Human>> GetHumans()
        {
            var humans = await dbContext.Humans.ToListAsync();

            return await Task.FromResult(humans);
        }
    }
}
