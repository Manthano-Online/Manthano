namespace Manthano.Domain.Models;

public class ReadThroughStats
{
    public BibleReadThrough ReadThrough { get; set; }
    public bool HasTargetDeadline => ReadThrough.TargetEndDate.HasValue;
    public int TotalDaysRead { get; set; }
    public int TotalSessions { get; set; }
    public double TotalDaysSinceReadThroughStart { get; set; }
    public DateTime FirstDayOfReadThrough { get; set; }
    public DateTime LastDayOfReadThrough { get; set; }
    public int TotalChaptersRead { get; set; }
    public int TotalChaptersLeftToRead { get; set; }
    public int? RequiredChaptersToMeetDeadline { get; set; }
    public double AverageChaptersPerDay { get; set; }
    public double DaysLeftToReadThrough { get; set; }
    public DateTime EstimatedDateForCompletion { get; set; }
    public BibleReadingSession LikelyNextSession { get; set; }
    public double PercentDone { get; set; }
    public IReadOnlyList<OverlappingSession> Overlaps { get; set; }
}
