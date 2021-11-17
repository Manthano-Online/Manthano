using Manthano.Domain.Models.Validators;

namespace Manthano.Domain.Models;

public class BookReadingSession : IEntity<int>
{
    public int Id { get; set; }

    public int BookReadThroughId { get; set; }

    public DateTime ReadOn { get; set; }

    [IntLessThanValidator(nameof(BookReadingSession.EndPage), CanBeEqual = true, ErrorMessage = "end page cannot be less than start page but may be equal")]
    public int StartPage { get; set; }

    public int EndPage { get; set; }

    public string Note { get; set; }

    public BookReadThrough BookReadThrough { get; set; }
}
