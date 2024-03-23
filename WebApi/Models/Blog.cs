using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public class Blog
{
    public int Id { get; set; }

    [Display(Name = "My Property")]
    public Guid? MyProperty { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTimeOffset? Created_date { get; set; }
    public DateTimeOffset? Last_updated_date { get; set; }
}
