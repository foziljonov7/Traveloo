using API.Data;
using API.Dtos;
using API.Entities;

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

        public Task<Human> DeleteHuman(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Human> EditHuman(Guid id, EditHumanDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<Human> GetHuman(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Human> GetHumans(string search)
        {
            throw new NotImplementedException();
        }
    }
}
