using System.Collections.Generic;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data.mocks
{
    public class MockCatagoryRepository : ICatagoryRepository
    {
       public IEnumerable<Catagory> Catagories {
            get 
            {
                return new List<Catagory>
                {
                new Catagory { CatagoryName= "Alcoholic", Description="All alcholic Drinks"},
                new Catagory { CatagoryName= "Non-alcholic",Description="All non-alcholic drinks"}
                };
            }
        }

    }
}
