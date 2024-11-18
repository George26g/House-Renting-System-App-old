namespace HouseRentingSystem.Services.Data.Entities
{
    public class Category()
    {
        public int Id {get; set;} 
        required public string Name;

        public static implicit operator string(Category v)
        {
            return v.Name;
        }

        public ICollection<House> CategorisedHouses { get; set; } = [];


    }
}