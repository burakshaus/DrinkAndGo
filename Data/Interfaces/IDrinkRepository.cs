// IDrinkRepository.cs

using DrinkAndGo.Data.Models;
using System.Collections.Generic;

namespace DrinkAndGo.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> GetDrinks();
        Drink GetDrinkById(int drinkId);
        void AddDrink(Drink drink);
        void UpdateDrink(Drink drink);
        void DeleteDrink(int drinkId);
    }
}
