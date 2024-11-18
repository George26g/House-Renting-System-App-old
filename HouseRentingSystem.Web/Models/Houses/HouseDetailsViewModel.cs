namespace HouseRentingSystem.Web.Models.Houses
{
    public class HouseDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public string RenterName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}