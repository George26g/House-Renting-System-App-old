namespace HouseRentingSystem.Services.Rents.Models
{
    public class RentServiceModel
    {
        public int HouseId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }

        public string AgentName { get; set; }
        public string AgentEmail { get; set; }

        public string RenterName { get; set; }
        public string RenterEmail { get; set; }
    }
}