#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Actividad.Models;


public class Passport
{

    public int id { get; set; }
    public string code { get; set; }
    public string created_at { get; set; }
    public string updated_at { get; set; }
}