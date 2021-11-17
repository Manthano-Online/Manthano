namespace Manthano.Domain.Models;

public class Group : IEntity<int>
{
    public int Id { get; set; }

    public string Name { get; set; }

    /// <summary>
    /// Specify a church id to prevent users from joining this group.
    /// </summary>
    public int? LimitToChurchId { get; set; }

    /// <summary>
    /// 0 == no limit. Limits the size of the group to prevent more users from joining.
    /// </summary>
    public int MaxSize { get; set; } = 0;

    /// <summary>
    /// Makes a group public that anyone can see. Joining will also depend on other properties of this class.
    /// </summary>
    public bool IsPublicGroup { get; set; }

    public int CreatedById { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.Now;

    public List<AppUser> Users { get; set; }
    public List<BibleReadThrough> BibleReadThroughs { get; set; }
    public List<Goal> Goals { get; set; }
}
