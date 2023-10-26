#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Actividad.Models;


public class Country
{
    public int id { get; set; }
    public string name { get; set; }
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public string image { get; set; }



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