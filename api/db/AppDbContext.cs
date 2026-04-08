using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    Id = 1,
                    Name = "Ivan",
                    Surname = "Ivanov",
                    Email = "ivan@example.com",
                    Age = 25,
                    RegistrationDate = DateTime.SpecifyKind(
                                        new DateTime(2024, 1, 10),
                                        DateTimeKind.Utc
                                    )
                },
                new Users
                {
                    Id = 2,
                    Name = "Petr",
                    Surname = "Petrov",
                    Email = "petr@example.com",
                    Age = 30,
                    RegistrationDate = DateTime.SpecifyKind(
                                        new DateTime(2024, 1, 10),
                                        DateTimeKind.Utc
                                    )
                },
                new Users
                {
                    Id = 3,
                    Name = "Anna",
                    Surname = "Smirnova",
                    Email = "anna@example.com",
                    Age = 22,
                    RegistrationDate = DateTime.SpecifyKind(
                                        new DateTime(2024, 1, 10),
                                        DateTimeKind.Utc
                                    )
                },
                new Users
                {
                    Id = 4,
                    Name = "Olga",
                    Surname = "Sidorova",
                    Email = "olga@example.com",
                    Age = 28,
                    RegistrationDate = DateTime.SpecifyKind(
                                        new DateTime(2024, 1, 10),
                                        DateTimeKind.Utc
                                    )
                },
                new Users
                {
                    Id = 5,
                    Name = "Dmitriy",
                    Surname = "Kuznetsov",
                    Email = "dmitriy@example.com",
                    Age = 35,
                    RegistrationDate = DateTime.SpecifyKind(
                                        new DateTime(2024, 1, 10),
                                        DateTimeKind.Utc
                                    )
                }
            );
        }
    }
}
