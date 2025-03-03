using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Moment3.Models;

public class Borrow{
    public int Id {get; set;}

    [Required]
    [DisplayName("Lånare")]
    public int? PersonId {get; set;}

    [DisplayName("Lånare")]
    public Person? Person {get; set;}

    [Required]
    [DisplayName("Bok")]
    public int? BookId {get; set;}

    [DisplayName("Bok")]
    public Book? Book {get; set;}
    

    [DisplayName("Datum")]
    public DateOnly Date {get; set;} = DateOnly.FromDateTime(DateTime.Now);
}