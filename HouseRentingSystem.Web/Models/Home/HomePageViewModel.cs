using HouseRentingSystem.Services.Houses.Models;

namespace HouseRentingSystem.Web.Models.Home
{
    public class HomePageViewModel
    {
        public IEnumerable<HouseIndexServiceModel> Houses { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAgent { get; set; }
    }
}