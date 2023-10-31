#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Actividad.Models;


public class Country
{
    [Key]
    public int CountryId { get; set; }
    public string name { get; set; }
    public string created_at { get; set; }
    public DateTime updated_at { get; set; } = DateTime.Now;
    public DateTime image { get; set; } = DateTime.Now;



    public void printName()
    {

        for (int i = 0; i < id; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine(i);
            }

        }

    }

}