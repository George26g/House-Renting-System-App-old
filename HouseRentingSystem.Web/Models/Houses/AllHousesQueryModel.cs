
using HouseRentingSystem.Services.Houses.Models;
using HouseRentingSystem.Services;

namespace HouseRentingSystem.Web.Models.Houses
{
    public class AllHousesQueryModel
    {
        // Filter properties
        public string Category { get; set; }
        public string SearchTerm { get; set; }
        public HouseSorting Sorting { get; set; } = HouseSorting.Newest;

        // List of available categories for filtering
        public IEnumerable<string> Categories { get; set; } = new List<string>();

        // Houses to be displayed
        public IEnumerable<HouseIndexServiceModel> Houses { get; set; } = new List<HouseIndexServiceModel>();

        // Pagination properties
        public int TotalHousesCount { get; set; }
        public int CurrentPage { get; set; } = 1;
        public const int HousesPerPage = 5; // Number of houses per page

        // Additional logic for pagination and sorting
        public int MaxPage => (int)Math.Ceiling((double)TotalHousesCount / HousesPerPage);
    }
}