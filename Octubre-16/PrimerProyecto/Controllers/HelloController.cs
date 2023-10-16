// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PrimerProyecto.Controllers;
public class HelloController : Controller   // Remember inheritance?    
{

    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        // will attempt to serve 
        // Views/Hello/Index.cshtml
        // or if that file isn't there:
        // Views/Shared/Index.cshtml
        return View();
    }

    [HttpGet("curso/overview")] // We will go over this in more detail on the next page    
    public ViewResult Overview()
    {
        return View("Overview");
    }


    [HttpGet("curso/{cursoId}")] // We will go over this in more detail on the next page    
    public string Curso(string cursoId)
    {

        return $"Curso {cursoId}!";
    }


    [HttpPost] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string PostIndex()
    {
        return "Hello World from HelloController! from POST";
    }

}