using Microsoft.EntityFrameworkCore;
using UserInfo.Models;

namespace Registry.Data.Repository;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }

}