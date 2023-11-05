using API.Data;
using API.Entities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext dbContext;

        public CategoryService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await dbContext.Categorys
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();

            if(category is null)
                return null;

            return category;
        }

        public async Task<List<Category>> GetCategorys()
        {
            var category = await dbContext.Categorys.ToListAsync();
            return category;
        }

        public async Task<List<Human>> GetHumanCategory(int cId)
        {
            var category = await dbContext.Humans
                .Where(c => c.CategoryId == cId)
                .ToListAsync();
                
            return category;
        }
    }
}
