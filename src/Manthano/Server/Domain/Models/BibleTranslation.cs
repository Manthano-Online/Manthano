namespace Manthano.Domain.Models;

public class BibleTranslation : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Language { get; set; }
    public int AddedBy { get; set; }

    public VerseCountingType VerseCountingType { get; set; }
    public AppUser User { get; set; }
}