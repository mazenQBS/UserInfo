using UserInfo.Models;

namespace Registry.Data.Repository;

public interface IUserRepository
{
    public void Create(User user);
    public void Update(User user);
    public void Delete(User user);
    public void DeleteById(int id);
    public User GitById(int id);
}