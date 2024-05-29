using EDA.Entity;

namespace EDA.Infra.Interface
{
    public interface IUserRepository
    {
        Task<UserDbo> GetUserByIdAsync(int userId);
        Task<List<UserDbo>> GetAllUserAsync();
        Task<UserDbo> CreateUserAsync(UserDbo user);
        Task<UserDbo> UpdateUserAsync(UserDbo user);
        Task DeleteUserAsync(int userId);
    }
}