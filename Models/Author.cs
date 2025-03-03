using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Moment3.Models;

public class Author{
    public int Id {get; set;}

    [DisplayName("Namn")]
    public string? Name {get; set;}
    
    [DisplayName("Kön")]
    public string? Gender {get; set;}
}