using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class BlogController : Controller
{
    // GET: /Blog/
    public string Index()
    {
        return "This is my default action";
    }

    // GET: /Blog/Welcome/
    public string Welcome()
    {
        return "This is the welcome action";
    }
}
