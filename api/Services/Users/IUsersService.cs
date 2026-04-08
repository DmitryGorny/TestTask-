using api.Dtos;

namespace api.Services.Users
{
    public interface IUsersService
    {
        public Task<IEnumerable<GetUsersDto>> GetUsersAsync();
    }
}
