using UserInfo.Models;

namespace Registry.Data.Repository;

public class UserRepository:IUserRepository
{
    private readonly UserDbContext _context;

    public UserRepository(UserDbContext context)
    {
        _context = context;
    }



    public void Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void Update(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
    }

    public void Delete(User user)
    {
        _context.Users.Remove(user);
        _context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var user = GitById(id);
        Delete(user);
    }

    public User GitById(int id)
        => _context.Users.FirstOrDefault(i => i.Id == id)?? throw new InvalidOperationException();
}