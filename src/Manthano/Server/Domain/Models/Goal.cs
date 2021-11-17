using Manthano.Domain.Models.Validators;

namespace Manthano.Domain.Models;

public class Goal : IEntity<int>
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int CreatedById { get; set; }

    public int? ChurchId { get; set; }

    public int? GroupId { get; set; }

    [DateLessThan(nameof(Goal.EndDate), ErrorMessage = "start date cannot be after end date.")]
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    /// <summary>
    /// A text summary of all the items in the goal, i.e. 13 books, 2 bible read throughs, 6 memory verses
    /// </summary>
    public string ScopeSummary { get; set; }

    /// <summary>
    /// Calculated percentage of the goal statistics.
    /// </summary>
    public double ProgressPercent { get; set; }
    public GoalDetails GoalDetails { get; set; } = new GoalDetails();

    public bool IsCompleted { get; set; }

    public AppUser Owner { get; set; }
    public Church Church { get; set; }
    public Group Group { get; set; }
    public List<BookReadThrough> BookReadThroughs { get; set; }
    public List<BibleReadThrough> BibleReadThroughs { get; set; }
}
