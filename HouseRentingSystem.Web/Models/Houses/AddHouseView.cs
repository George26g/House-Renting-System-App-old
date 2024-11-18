namespace HouseRentingSystem.Web.Models.Houses
{
    public class AddHouseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal PricePerMonth { get; set; }
        public int CategoryId { get; set; }
        public IFormFile Image { get; set; }
    }
}