using api.Dtos;

namespace api.Mappers
{
    public static class UsersMapper
    {
        public static GetUsersDto ToGetUsersDto(this Models.Users user)
            {
                return new GetUsersDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Age = user.Age,
                    RegistrationDate = user.RegistrationDate,
                    Surname = user.Surname,
                };
        }
    }
}
