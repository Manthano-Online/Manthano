namespace Manthano.Domain.Models;

public class BookReadThrough : IEntity<int>
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int UserId { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }
    public bool IsOwned { get; set; }
    public bool IsDigital { get; set; }
    public DateTime? DeadlineOn { get; set; }

    public string Review { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now.Date;
    public double ProgressPercent { get; set; }
    public int ReadPages { get; set; }

    public Book Book { get; set; }
    public AppUser User { get; set; }
    public List<Goal> Goals { get; set; }
    public List<BookReadingSession> BookReadingSessions { get; set; }

    public double GetProgressOfReadthrough()
    {
        if (IsCompleted)
        {
            return 100;
        }

        if (BookReadingSessions?.Count > 0 && Book != null)
        {
            double totalPages = Book.EndPage - Book.StartPage + 1;
            double readPages = BookReadingSessions.Sum(x => x.EndPage - x.StartPage + 1);
            return Math.Round((readPages / totalPages) * 100d, 2);
        }

        return 0;
    }
}