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
        Country colombia = new Country()
        {
            id = 10,
            name = "Colombia",
            created_at = "2023-10-24",
            updated_at = "2023-10-24",
            image = "https://cdn.britannica.com/68/7668-050-9304EBB7/Flag-Colombia.jpg",
        };

        return Json(colombia);
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

    [HttpGet("/Country/bucles")]
    public string CountryLoops()
    {

        List<string> StringList = new List<string>() { "one", "two", "eleven", "three", "four", "five" };

        foreach (string word in StringList)
        {
            Console.WriteLine(word);

            if (word.Length > 5)
            {
                break;
            }
            // We can render HTML from within C# code!
            // We just have to remember to bring @ back if we want to render variables
        }

        int idx = 0;
        Console.WriteLine();
        while (StringList[idx].Length < 6)
        {
            Console.WriteLine(StringList[idx]);
            idx++;
        }




        return countryList;
    }


    [HttpGet("/Country/All")]
    public IActionResult ViewAllCountries()
    {

        List<Country> countries = new List<Country>();


        Country chile = new Country()
        {
            id = 10,
            name = "Chile",
            created_at = "2023-10-24",
            updated_at = "2023-10-24",
            image = "https://cdn.britannica.com/85/7485-050-2615417F/Flag-Chile.jpg",
        };
        Country argentina = new Country()
        {
            id = 12,
            name = "Argentina",
            created_at = "2023-10-24",
            updated_at = "2023-10-24",
            image = "https://cdn.britannica.com/69/5869-050-6DD75C6F/Flag-Argentina.jpg",
        };
        Country ecuador = new Country()
        {
            id = 23,
            name = "Ecuador",
            created_at = "2023-10-24",
            updated_at = "2023-10-24",
            image = "https://cdn.britannica.com/49/149-050-7AD40B1F/flag-design-similarities-Ecuador-Colombia-flags-Venezuela.jpg",
        };
        countries.Add(chile);
        countries.Add(argentina);
        countries.Add(ecuador);


        return View("~/Views/Country/AllCountries.cshtml", countries);
    }


}