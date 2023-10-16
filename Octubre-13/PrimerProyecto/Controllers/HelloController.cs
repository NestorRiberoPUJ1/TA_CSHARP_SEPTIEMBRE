// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PrimerProyecto.Controllers;
public class HelloController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string Index()
    {
        return "Hello World from HelloController!";
    }


    [HttpPost] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string PostIndex()
    {
        return "Hello World from HelloController! from POST";
    }

}