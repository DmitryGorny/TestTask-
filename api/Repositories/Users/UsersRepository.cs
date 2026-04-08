using api.db;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories.Users
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _dbContext;
        public UsersRepository(AppDbContext appDbContext) 
        {
            _dbContext = appDbContext;
        }

        public async Task<IEnumerable<Models.Users>> GetUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
