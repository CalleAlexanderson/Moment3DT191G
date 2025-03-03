using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Moment3.Models;

public class Person{
    public int Id {get; set;}

    [DisplayName("Namn")]
    public string? Name {get; set;}
    
    [DisplayName("E-post")]
    [EmailAddress(ErrorMessage ="Du måste ange en giltig e-post adress")]
    public string? Email {get; set;}

}