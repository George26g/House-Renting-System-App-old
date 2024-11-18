namespace HouseRentingSystem.Services.Data.Entities{

   public class House
    {
        public int Id { get; set; }
        // public string? Category { get; set; }

        public string? Title {get; set;}
        // public string Address { get; set; }
        // public decimal Price { get; set; }
        public string? Address {get; set;}
        public string? Description {get; set;}
        public string? ImageUrl {get; set;}
        public decimal? PricePerMonth {get; set;}

        public int AgentId {get; set;}
        public Agent Agent;

        public int CategoryId {get; set;}
        public Category Category;

        public int? RenterId {get; set;}
        public User? Renter;


        // public ICollection<Rental> Rentals { get; set; }
    }
}