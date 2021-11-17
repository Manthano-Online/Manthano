using Manthano.Common.Extensions;

namespace Manthano.Domain.Models;

public class Book : IEntity<int>
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Subtitle { get; set; }

    public string AlternativeTitle { get; set; }

    public int StartPage { get; set; }

    public int EndPage { get; set; }

    public int YearOfPublication { get; set; }

    public string Publisher { get; set; }

    public string Author { get; set; }

    public string Isbn { get; set; }

    public int CreatedById { get; set; }
    public AppUser Creator { get; set; }
    public List<BookReadThrough> BookReadThroughs { get; set; }

    public bool IsValid()
    {
        if (EndPage < StartPage)
        {
            return false;
        }

        if (Title.IsNullOrWhiteSpace() || Author.IsNullOrWhiteSpace())
        {
            return false;
        }

        if (CreatedById <= 0)
        {
            return false;
        }

        return true;
    }
}