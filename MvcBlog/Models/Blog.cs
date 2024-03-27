using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models;

public class Blog
{
    public int Id { get; set; }
    public int Author { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTimeOffset Created_date { get; set; }
    public DateTimeOffset Last_update { get; set; }
}
