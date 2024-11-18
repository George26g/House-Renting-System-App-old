namespace HouseRentingSystem.Services.Agents
{
    public interface IAgentService
    {
        //bool UserHasRents(string userId);

        bool AgentWithPhoneNumberExists(string phoneNumber);
       
        int GetAgentId(int userId);

        bool ExistsById(int userId);


        void Create(int userId, string phoneNumber);
    }
}

