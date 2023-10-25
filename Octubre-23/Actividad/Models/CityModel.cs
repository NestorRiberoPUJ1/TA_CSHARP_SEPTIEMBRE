#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Actividad.Models;



public class City
{
    public int id { get; set; }

    public string name { get; set; }

    public string created_at { get; set; }

    public string updated_at { get; set; }

}