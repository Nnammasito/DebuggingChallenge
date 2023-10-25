#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DebuggingChallenge.Models;

public class User
{
    //Ingresar la validación y el mensaje
    [Required(ErrorMessage = "Ingrese nombre")]
    [MinLength(4, ErrorMessage = "Ingrese nombre")]
    public string Name {get;set;}

    public string? Location {get;set;}
}