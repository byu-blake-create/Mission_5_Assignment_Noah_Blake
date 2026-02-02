using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission_5_Assignment_Noah_Blake.Models;

namespace Mission_5_Assignment_Noah_Blake.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Calculator()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}