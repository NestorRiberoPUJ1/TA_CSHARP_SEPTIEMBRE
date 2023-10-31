
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DirectorioAPI.Models;

namespace DirectorioAPI.Controllers;


public class ApiController : Controller
{

    public static List<User> users = new List<User>();


    [HttpPost("/api/user")]
    public IActionResult CreateUser(string FirstName, string LastName, int Age)
    {
        /* Acciones de creacion */
        Console.WriteLine(FirstName);
        Console.WriteLine(LastName);
        Console.WriteLine(Age);

        User newUser = new User()
        {
            FirstName = FirstName,
            LastName = LastName,
            Age = Age,
        };

        users.Add(newUser);
        Console.WriteLine(users);

        return Json(newUser);
    }


    [HttpGet("/api/user")]
    public IActionResult GetAllUsers()
    {

        return Json(users);
    }

}