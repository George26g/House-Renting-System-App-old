using HouseRentingSystem.Services.Houses.Models;

namespace HouseRentingSystem.Web.Models.Agents
{
    public class AgentProfileViewModel
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string ContactInfo { get; set; }
        public string Bio { get; set; }
        public IEnumerable<HouseIndexServiceModel> ManagedHouses { get; set; }
    }
}