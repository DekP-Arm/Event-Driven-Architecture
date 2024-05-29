
using EDA.Entity;
using EDA.Infra.Interface;
using EDA;
using Microsoft.EntityFrameworkCore;

namespace EDA.Infra.Repositories
{
    public class UserRepository : IUserRepository{

        private readonly DataContext _dbcontext;

        public UserRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<UserDbo> GetUserByIdAsync(int userId)
        {
            UserDbo? user = await _dbcontext.User.FindAsync(userId);
            return user;
        }

        public async Task<List<UserDbo>> GetAllUserAsync()
        {
            List<UserDbo> users = await _dbcontext.User.ToListAsync();
            return users;
        }

        public async Task<UserDbo> CreateUserAsync(UserDbo user)
        {
            await _dbcontext.User.AddAsync(user);
            await _dbcontext.SaveChangesAsync();
            return user;
        }

        public async Task<UserDbo> UpdateUserAsync(UserDbo user)
        {
            _dbcontext.User.Update(user);
            await _dbcontext.SaveChangesAsync();
            return user;
        }

        public async Task DeleteUserAsync(int userId)
        {
            var user = await _dbcontext.User.FindAsync(userId);
            _dbcontext.User.Remove(user);
            await _dbcontext.SaveChangesAsync();
        }

    }
}