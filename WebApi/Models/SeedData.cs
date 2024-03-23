using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Data;
using WebApi.Models;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (
            var context = new BlogContext(
                serviceProvider.GetRequiredService<DbContextOptions<BlogContext>>()
            )
        )
        {
            // Look for any movies.
            if (context.Blog.Any())
            {
                return; // DB has been seeded
            }
            context.Blog.AddRange(
                new Blog
                {
                    MyProperty = new Guid(),
                    Content = "Content",
                    Title = "New Title",
                    Created_date = new DateTimeOffset(),
                    Last_updated_date = new DateTimeOffset(),
                },
                new Blog
                {
                    MyProperty = new Guid(),
                    Content = "Content 1",
                    Title = "New Title 1",
                    Created_date = new DateTimeOffset(),
                    Last_updated_date = new DateTimeOffset(),
                },
                new Blog
                {
                    MyProperty = new Guid(),
                    Content = "Content 2",
                    Title = "New Title 2",
                    Created_date = new DateTimeOffset(),
                    Last_updated_date = new DateTimeOffset(),
                }
            );
            context.SaveChanges();
        }
    }
}
