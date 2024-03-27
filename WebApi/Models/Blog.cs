using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public class Blog
{
    public int Id { get; set; }

    [Display(Name = "My Property")]
    public Guid? MyProperty { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Title { get; set; }
    public string Content { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
    public string Genre { get; set; }

    // public string GenreTwo { get; set; }
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTimeOffset? Created_date { get; set; }

    [DataType(DataType.DateTime)]
    public DateTimeOffset? Last_updated_date { get; set; }
}
