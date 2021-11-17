namespace Manthano.Domain.Models;

public class UserSettings : IEntity<int>
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public AppUser User { get; set; }
    public UserLanguage Language { get; set; }

    public UserSettings(int userId)
    {
        UserId = userId;
    }

    public UserSettings() { }
}
