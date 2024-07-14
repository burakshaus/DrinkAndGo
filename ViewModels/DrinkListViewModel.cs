using DrinkAndGo.Models;
namespace DrinkAndGo.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCatagory { get; set; }
    }
}
