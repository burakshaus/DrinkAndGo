namespace DrinkAndGo.Data.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public string Description { get; set; }
        public List<Drink> Drinks { get; set; }

    }
}
