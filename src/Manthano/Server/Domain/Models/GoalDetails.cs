namespace Manthano.Domain.Models;

public class GoalDetails
{
    public double BookProgressPercent { get; set; }
    public double BibleProgressPercent { get; set; }
    public double MemoProgressPercent { get; set; }
    public int TotalBookPages { get; set; }
    public int TotalBibleChapters { get; set; }
    public int TotalMemoVerses { get; set; }
    public int CountCompletedBookPages { get; set; }
    public int CountCompletedBibleChapters { get; set; }
    public int CountMemoVerses { get; set; }
}
