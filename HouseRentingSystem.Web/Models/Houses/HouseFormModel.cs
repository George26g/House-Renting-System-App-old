using System.ComponentModel.DataAnnotations;
// using HouseRentingSystem.Services.Houses.Models;

namespace HouseRentingSystem.Web.Models.Houses
{
    public class HouseFormModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The title must be between 5 and 100 characters.")]
        [Display(Name = "House Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 20, ErrorMessage = "The description must be between 20 and 1000 characters.")]
        [Display(Name = "House Description")]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "The price must be a positive value.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "The number of rooms must be between 1 and 10.")]
        [Display(Name = "Number of Rooms")]
        public int NumberOfRooms { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "The number of bathrooms must be between 1 and 10.")]
        [Display(Name = "Number of Bathrooms")]
        public int NumberOfBathrooms { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "The size must be a positive value.")]
        [Display(Name = "Size (sq. meters)")]
        public double Size { get; set; }

        // Optional field for additional notes, can be null
        [StringLength(500, ErrorMessage = "The note must be less than 500 characters.")]
        [Display(Name = "Additional Notes")]
        public string Notes { get; set; }
    }
}