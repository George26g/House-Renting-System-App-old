namespace HouseRentingSystem.Services.Data.Entities
{

    public class User
    {
        public required int Id;

        public required string Email;

        public required string FirstName;

        public required string LastName;

        public string? FullName;

        public ICollection<House> RentedHouses { get; set; } = [];

    }
}