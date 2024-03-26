using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApi.Models;

public class BlogGenreViewModel
{
    public List<Blog>? Blogs { get; set; }
    public SelectList? Genres { get; set; }
    public string? BlogGenre { get; set; }
    public string? SearchString { get; set; }
}
