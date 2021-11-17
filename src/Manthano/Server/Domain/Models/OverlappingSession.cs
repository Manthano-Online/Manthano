namespace Manthano.Domain.Models;

public class OverlappingSession
{
    public int SessionId { get; set; }
    public string SessionTitle { get; set; }
    public List<int> OverlappingChapterIds { get; set; } = new List<int>();

    public OverlappingSession(int sessionId)
    {
        SessionId = sessionId;
    }

    public OverlappingSession AddOverlappingChapter(int id)
    {
        OverlappingChapterIds.Add(id);
        return this;
    }
}
