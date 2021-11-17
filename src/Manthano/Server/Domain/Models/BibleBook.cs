using System.ComponentModel.DataAnnotations;

namespace Manthano.Domain.Models;

public class BibleBook : IEntity<int>
{
    public int Id { get; set; }

    public string BookNameDe { get; set; }

    public string BookNameEn { get; set; }

    public string BookNameShortDe { get; set; }

    public string BookNameShortEn { get; set; }

    [Range(1, 150)]
    public int ChaptersLxx { get; set; }

    [Range(1, 150)]
    public int ChaptersHeb { get; set; }
}
