using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly DrinkAndGoDbContext _context;

        public DrinkRepository(DrinkAndGoDbContext context)
        {
            _context = context;
        }

        public void AddDrink(Drink drink)
        {
            _context.Drinks.Add(drink);
            _context.SaveChanges();
        }

        public void DeleteDrink(int drinkId)
        {
            var drink = _context.Drinks.Find(drinkId);
            if (drink != null)
            {
                _context.Drinks.Remove(drink);
                _context.SaveChanges();
            }
        }

        public Drink GetDrinkById(int drinkId)
        {
            return _context.Drinks.FirstOrDefault(d => d.DrinkId == drinkId);
        }

        public IEnumerable<Drink> GetDrinks()
        {
            return _context.Drinks.ToList();
        }

        public void UpdateDrink(Drink drink)
        {
            _context.Drinks.Update(drink);
            _context.SaveChanges();
        }
    }
}
