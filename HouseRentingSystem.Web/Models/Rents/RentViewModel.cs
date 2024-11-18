namespace HouseRentingSystem.Web.Models.Rents
{
    public class RentHouseViewModel
    {
        public int HouseId { get; set; }
        public int UserId { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }
        public decimal RentAmount { get; set; }
    }
}