using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission_5_Assignment_Noah_Blake.Models;

namespace Mission_5_Assignment_Noah_Blake.Controllers;

public class HomeController : Controller
{
    // Landing page for the hobby site content.
    public IActionResult Index()
    {
        return View();
    }

    // Tutoring calculator page for estimating total cost.
    public IActionResult Calculator()
    {
        return View();
    }

    // Default error view with request tracing info.
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
