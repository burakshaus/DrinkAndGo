// ICategoryRepository.cs

using DrinkAndGo.Data.Models;
using System.Collections.Generic;

namespace DrinkAndGo.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int categoryId);
    }
}
