using Registry.Domain.Model;

namespace UserInfo.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public DateTime Birthday { get; set; }

    public Gender Gender { get; set; }

    public string Image { get; set; }
}