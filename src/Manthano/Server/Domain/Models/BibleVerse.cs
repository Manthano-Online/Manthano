namespace Manthano.Domain.Models;

public class BibleVerse : IEntity<int>
{
    public int Id { get; set; }
    public int BibleBookId { get; set; }
    public int? BibleChapterLxx { get; set; }
    public int? BibleChapterHeb { get; set; }
    public int? VerseLxx { get; set; }
    public int? VerseHeb { get; set; }
}
