namespace Manthano.Domain.Models;

public class PagingFilter
{
    public PagingFilter(int pageIndex = 0, int pageSize = 20)
    {
        PageIndex = pageIndex;
        PageSize = pageSize;
    }

    public int PageIndex { get; }
    public int PageSize { get; }
    public int SkippedItems => PageIndex * PageSize;
}
