namespace DrinkAndGo.Data.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPrefferedDrink { get; set; }
        public bool InStock { get; set; }
        public int CatagoryId { get; set; }
        public virtual Catagory Catagory { get; set; }

    }
}
