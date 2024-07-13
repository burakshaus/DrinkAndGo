using System.Collections.Generic;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink>? PrefferredDrinks { get; set; }
        Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
