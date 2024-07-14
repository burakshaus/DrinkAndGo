// CategoryRepository.cs

using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DrinkAndGoDbContext _context;

        public CategoryRepository(DrinkAndGoDbContext context)
        {
            _context = context;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
