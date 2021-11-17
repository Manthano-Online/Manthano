using Manthano.Domain.Models.Validators;
using System.ComponentModel.DataAnnotations;

namespace Manthano.Domain.Models;

public class BibleReadingSession : IEntity<int>
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public int ReadThroughId { get; set; }

    [Range(1, 1190)]
    [IntLessThanValidator(nameof(EndChapterId), CanBeEqual = true, ErrorMessage = "end chapter cannot be less than start chapter but may be equal")]
    public int StartChapterId { get; set; }

    [Range(1, 1190)]
    public int EndChapterId { get; set; }

    public DateTime Date { get; set; }

    public BibleReadThrough ReadThrough { get; set; }
    public AppUser User { get; set; }

    public BibleReadingSession(string userId, int readThroughId, int startChapterId, int endChapterId, DateTime date)
    {
        UserId = userId;
        ReadThroughId = readThroughId;
        StartChapterId = startChapterId;
        EndChapterId = endChapterId;
        Date = date;
    }

    public BibleReadingSession()
    {

    }
}