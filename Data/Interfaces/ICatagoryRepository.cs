using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data.Interfaces
{
    public interface ICatagoryRepository
    {
        IEnumerable<Catagory> Catagories { get; }
    }
}
