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
        
        HttpContext.Session.SetString("UserName", "Samantha");

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
        
        // To retrieve a string from session we use ".GetString"
        string LocalVariable = HttpContext.Session.GetString("UserName");
        ViewBag.MyNum = LocalVariable;
        
        return View("~/Views/User/View.cshtml", newUser);
    }

    [HttpPost("user")]
    public IActionResult createUser(User newUser)
    {

        return RedirectToAction("user"); ;
    }

}