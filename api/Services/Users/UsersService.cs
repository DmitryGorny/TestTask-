using api.Dtos;
using api.Mappers;
using api.Repositories.Users;

namespace api.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public async Task<IEnumerable<GetUsersDto>> GetUsersAsync()
        {
            var users = await _usersRepository.GetUsersAsync();
            return users.Select(u => u.ToGetUsersDto());
        }
    }
}
