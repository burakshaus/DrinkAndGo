// AddDrinkViewModel.cs

using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DrinkAndGo.ViewModels
{
    public class AddDrinkViewModel
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a short description")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Please enter a long description")]
        public string LongDescription { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }

        public List<Category> Categories { get; set; }

        [Required(ErrorMessage = "Please enter the URL of the image")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Please enter the URL of the thumbnail image")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string ImageThumbnailUrl { get; set; }

        public bool IsPreferredDrink { get; set; }
        public bool InStock { get; set; }
    }
}
