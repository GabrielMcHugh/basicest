namespace WebApi.Models;

public class BlogModel
{
    public int Id { get; set; }
    public Guid MyProperty { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTimeOffset Created_date { get; set; }
    public DateTimeOffset? Last_updated_date { get; set; }
}
