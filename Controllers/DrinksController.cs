using Microsoft.AspNetCore.Mvc;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using System.Linq;

namespace DrinkAndGo.Controllers
{
    public class DrinksController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DrinksController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: Drinks/Add
        public IActionResult Add()
        {
            var categories = _categoryRepository.GetCategories().ToList();
            var model = new AddDrinkViewModel
            {
                Categories = categories
            };
            return View(model);
        }

        // POST: Drinks/Add
        [HttpPost]
        [HttpPost]
        public IActionResult Add(AddDrinkViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Handle validation errors
                var categories = _categoryRepository.GetCategories().ToList();
                model.Categories = categories;
                return View(model);
            }

            var category = _categoryRepository.GetCategoryById(model.CategoryId);

            var newDrink = new Drink
            {
                Name = model.Name,
                Price = model.Price,
                ShortDescription = model.ShortDescription,
                LongDescription = model.LongDescription,
                Category = category,
                ImageThumbnailUrl = model.ImageThumbnailUrl,
                ImgUrl = model.ImageUrl,
                InStock = model.InStock, // Ensure this is correctly mapped
                IsPreferredDrink = model.IsPreferredDrink // Ensure this is correctly mapped
            };

            _drinkRepository.AddDrink(newDrink);

            return RedirectToAction("Index", "Home");
        }


        // GET: Drinks/List
        public IActionResult List()
        {
            var drinkListViewModel = new DrinkListViewModel
            {
                Drinks = _drinkRepository.GetDrinks(),
                CurrentCategory = "Drink Category"
            };
            return View(drinkListViewModel);
        }
    }
}
