using System.ComponentModel.DataAnnotations;

namespace Manthano.Domain.Models;

public class Church : IEntity<int>
{
    public int Id { get; set; }

    [Required(AllowEmptyStrings = false)]
    public string Name { get; set; }

    public string City { get; set; }

    public string Denomination { get; set; }

    public string Website { get; set; }

    public List<AppUser> Members { get; set; }
    public List<Goal> Goals { get; set; }
}
