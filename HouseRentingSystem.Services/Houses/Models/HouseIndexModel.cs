namespace HouseRentingSystem.Services.Houses.Models
{
    public class HouseIndexServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public decimal PricePerMonth { get; set; }
    }
}