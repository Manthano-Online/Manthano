using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Manthano.Domain.Models;

public class BibleChapter : IEntity<int>
{
    public int Id { get; set; }

    public int BibleBookId { get; set; }

    [AllowNull]
    [Range(1, 150)]
    public int? ChapterHeb { get; set; }

    [AllowNull]
    [Range(1, 150)]
    public int? ChapterLxx { get; set; }

    [Range(1, 176)]
    public int VersesHeb { get; set; }

    [Range(1, 176)]
    public int VersesLxx { get; set; }

    public int WordsInChapter { get; set; }

    public int? LxxOrder { get; set; }

    public int? HebOrder { get; set; }

    [NotMapped]
    public BibleBook Book { get; set; }
}
