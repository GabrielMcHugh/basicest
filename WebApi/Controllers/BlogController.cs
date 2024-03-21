using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class BlogController : Controller
{
    // GET: /Blog/
    public IActionResult Index()
    {
        return View();
    }

    // GET: /Blog/Welcome/
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
