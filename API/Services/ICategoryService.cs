using API.Entities;

namespace API.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategorys();
        Task<Category> GetCategory(int id);
        Task<List<Human>> GetHumanCategory(int cId);
    }
}
