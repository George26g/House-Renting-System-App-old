using HouseRentingSystem.Services.Users.Models;

namespace HouseRentingSystem.Services.Users
{
    public interface IUserService
    {
        bool UserHasRents(int userId);
        string UserFullName(int userId);
        IEnumerable<UserServiceModel> All();
    }
}
