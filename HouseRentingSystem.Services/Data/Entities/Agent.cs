namespace HouseRentingSystem.Services.Data.Entities
{
    public class Agent
    {
        public int Id { get; set; }

        public required string PhoneNumber;

        public int UserId { get; set; }
        public User? User;

        public ICollection<House> Houses { get; set; } = [];

    }
}