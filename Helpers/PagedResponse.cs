namespace Cadeteria;
public class PagedResponse<T> : Response<T>
{
    public int TotalPages { get; set; }
    public int pageNumber { get; set; }

    public PagedResponse(T data, int todalPage, int pageNumber) : base(data)
    {
        this.Data = data;
        this.TotalPages = todalPage;
        this.pageNumber = pageNumber;
    }
}