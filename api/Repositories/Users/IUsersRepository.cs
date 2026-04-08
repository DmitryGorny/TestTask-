using api.Models;

namespace api.Repositories.Users
{
    public interface IUsersRepository
    {
        public Task<IEnumerable<Models.Users>> GetUsersAsync();
    }
}
