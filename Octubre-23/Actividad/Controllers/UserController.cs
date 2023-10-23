using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Actividad.Models;

namespace Actividad.Controllers;

public class UserController : Controller
{

    [HttpGet("user")]
    public IActionResult user()
    {
        ViewBag.MyNum = 9;

        int myViewModelNum = 12;

        return View("~/Views/User/Index.cshtml", myViewModelNum);
    }

    [HttpGet("user/view")]
    public IActionResult userView()
    {
        User newUser = new User()
        {
            FirstName = "Nichole",
            LastName = "King",
            Age = 21,
        };
        return View("~/Views/User/View.cshtml", newUser);
    }

    [HttpPost("user")]
    public IActionResult createUser(User newUser)
    {

        return RedirectToAction("user"); ;
    }

}