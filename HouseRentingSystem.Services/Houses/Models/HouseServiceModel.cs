namespace HouseRentingSystem.Services.Houses.Models
{
    public class HouseServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal PricePerMonth { get; set; }

        // Related Agent Info
        public int AgentId { get; set; }
        public string AgentName { get; set; }

        // Related Category Info
        public string CategoryName { get; set; }

        // Renter Info
        public string RenterId { get; set; }
        public string RenterName { get; set; }
    }
}