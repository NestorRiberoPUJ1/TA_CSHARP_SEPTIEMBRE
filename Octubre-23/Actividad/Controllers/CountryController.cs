using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Actividad.Models;

namespace Actividad.Controllers;

public class CountryController : Controller
{
    string countryList = "Chile,Colombia";


    /* Devuelve String  */
    [HttpGet("/Country")]
    public string ViewCountries()
    {
        return countryList;
    }

    [HttpGet("/Country/view")]
    public ViewResult ViewCountryPage()
    {

        ViewBag.Example = "Ejemplo de ViewBag";

        return View("~/Views/Country/Index.cshtml");
    }

    [HttpGet("/Country/redirect")]

    public RedirectResult RedirectToCountryView()
    {
        return Redirect("/Country/view");
    }

    [HttpGet("/Country/any")]
    public JsonResult GetCountry()
    {
        Country chile = new Country()
        {
            id = 10,
            name = "Chile",
            created_at = "2023-10-24",
            updated_at = "2023-10-24",
        };

        return Json(chile);
    }

    [HttpGet("/Country/{favoriteResponse}")]
    public IActionResult ItDepends(string favoriteResponse)
    {
        if (favoriteResponse == "Redirects")
        {
            return RedirectToAction("GetCountry");
        }
        else if (favoriteResponse == "Json")
        {
            Country chile = new Country()
            {
                id = 10,
                name = "Chile",
                created_at = "2023-10-24",
                updated_at = "2023-10-24",
            };

            return Json(chile);
        }
        else
        {
            // This route will require that an "ItDepends.cshtml" exists
            return View("~/Views/Country/Index.cshtml");
        }
    }


}