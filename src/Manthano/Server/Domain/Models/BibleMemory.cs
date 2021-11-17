namespace Manthano.Domain.Models;

public class BibleMemory
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public int BibleBookId { get; set; }
    public int StartChapter { get; set; }
    public int StartVerse { get; set; }
    public int EndChapter { get; set; }
    public int EndVerse { get; set; }
    public VerseCountingType CountingType { get; set; }
    public bool IsBibleVerse { get; set; }
    public RetentionInterval RetentionInterval { get; set; }
}
