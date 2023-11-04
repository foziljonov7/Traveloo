using API.Dtos;
using API.Entities;

namespace API.Services
{
    public interface IHumanService
    {
        Task<IEnumerable<Human>> GetHumans();
        Task<Human> GetHuman(Guid id);
        Task<Human> CreateHuman(CreateHumanDto dto);

        Task<Human> EditHuman(Guid id, EditHumanDto dto);                                           
        Task<Human> DeleteHuman(Guid id);
    }
}
