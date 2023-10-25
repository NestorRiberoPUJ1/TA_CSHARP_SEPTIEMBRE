using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Actividad.Models;

namespace Actividad.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        Country chile = new Country()
        {
            id = 10,
            name = "Chile",
            created_at = "2023-10-24",
            updated_at = "2023-10-24",
        };

        chile.printName();


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
