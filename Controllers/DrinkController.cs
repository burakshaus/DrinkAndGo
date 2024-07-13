using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class DrinkController:Controller
    {
        private readonly ICatagoryRepository _catagoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICatagoryRepository catagoryRepository, IDrinkRepository drinkRepository)
        {
            _catagoryRepository = catagoryRepository;
            _drinkRepository = drinkRepository;
        }
        public ViewResult List() 
        {
            ViewBag.Name = ".Net, How?";
            var drinks = _drinkRepository.Drinks;
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCatagory = "DrinkCatagory";
            return View(vm);
        }
    }
}
 