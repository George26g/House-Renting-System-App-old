namespace HouseRentingSystem.Services.Users.Models
{
    public class UserServiceModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public bool IsAgent { get; set; }
    }
}