#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DirectorioAPI.Models;


public class User
{
    [Required(ErrorMessage = "FirstName is required!")]
    [MinLength(3, ErrorMessage = "Message must be at least 3 characters in length.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "LastName is required!")]
    [MinLength(3, ErrorMessage = "Message must be at least 3 characters in length.")]
    public string LastName { get; set; }

    [Range(1, 100, ErrorMessage = "Age must be greater than 0")]
    public int Age { get; set; }

    public DateTime Created_At { get; set; } = DateTime.Now;

    public DateTime Updated_At { get; set; } = DateTime.Now;

}