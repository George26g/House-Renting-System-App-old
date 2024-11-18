using HouseRentingSystem.Services.Houses.Models;

namespace HouseRentingSystem.Web.Models.Users
{
    public class UserProfileViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<HouseIndexServiceModel> RentedHouses { get; set; }
    }
}