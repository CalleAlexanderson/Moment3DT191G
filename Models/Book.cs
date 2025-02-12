namespace Moment3.Models;

public class Book{
    public int Id {get; set;}
    public string? Title {get; set;}
    public string? Series {get; set;}
    public int ISBN {get; set;}
    public int? AuthorId {get; set;}
    public Author? Author {get; set;}
}