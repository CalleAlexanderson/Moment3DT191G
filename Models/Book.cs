using System.ComponentModel;
namespace Moment3.Models;

public class Book{
    public int Id {get; set;}
    [DisplayName("Titel")]
    public string? Title {get; set;}
    [DisplayName("Serie")]
    public string? Series {get; set;}
    public int ISBN {get; set;}
    public int? AuthorId {get; set;}
    [DisplayName("Författare")]
    public Author? Author {get; set;}
}