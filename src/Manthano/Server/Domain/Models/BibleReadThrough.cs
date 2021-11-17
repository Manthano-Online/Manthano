using System.ComponentModel.DataAnnotations;

namespace Manthano.Domain.Models;

public class BibleReadThrough : IEntity<int>
{
    public int Id { get; set; }

    [MaxLength(255)]
    public string Name { get; set; }

    public DateTime StartDate { get; set; }

    /// <summary>
    /// Is either the date when the read through was marked as completed or the target end date set by the user.
    /// </summary>
    public DateTime? TargetEndDate { get; set; }

    public int UserId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "This is not a valid Bible translation.")]
    public int BibleTranslationId { get; set; }
    public bool IsCompleted { get; set; }

    // TODO: add to edit and create forms
    public bool IsSharedWithChurch { get; set; }

    public int? GroupId { get; set; }

    public double ProgressPercent { get; set; }

    public DateTime ExpectedEndDate { get; set; }

    public int ReadChapters { get; set; }

    public int RequiredChapters { get; set; }

    public BibleReadThrough(DateTime startDate, int userId, int bibleTranslationId)
    {
        StartDate = startDate;
        UserId = userId;
        BibleTranslationId = bibleTranslationId;
    }

    public BibleReadThrough() { }

    public BibleTranslation BibleTranslation { get; set; }
    public AppUser User { get; set; }
    public List<BibleReadingSession> Sessions { get; set; }
    public List<Goal> Goals { get; set; }
    public List<Group> Groups { get; set; }

    public double GetProgressOfReadthrough()
    {
        if (IsCompleted)
        {
            return 100;
        }

        if (Sessions?.Count > 0)
        {
            double readPages = Sessions.Sum(x => x.EndChapterId - x.StartChapterId + 1);
            return Math.Round((readPages / 1189) * 100d, 2);
        }

        return 0;
    }
}