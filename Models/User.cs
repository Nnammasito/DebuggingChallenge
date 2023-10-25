#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DebuggingChallenge.Models;

public class User
{

    [Required]
    [MinLength(4, ErrorMessage = "Ingrese nombre")]
    public string Name {get;set;}

    public string? Location {get;set;}
}