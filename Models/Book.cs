using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Moment3.Models;

public class Book{
    public int Id {get; set;}
    [DisplayName("Titel")]
    public string? Title {get; set;}
    [DisplayName("Serie")]
    public string? Series {get; set;}

    [MinLength(10, ErrorMessage = "ISBN måste vara mellan 10-13 tecken långt")]
    [MaxLength(13)]
    public string? ISBN {get; set;}
    public int? AuthorId {get; set;}
    [DisplayName("Författare")]
    public Author? Author {get; set;}
}