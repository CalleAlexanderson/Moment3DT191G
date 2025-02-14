using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Moment3.Models;

public class Borrow{
    public int Id {get; set;}
    public int? PersonId {get; set;}
    [DisplayName("Lånare")]
    public Person? Person {get; set;}
    public int? BookId {get; set;}
    [DisplayName("Bok")]
    public Book? Book {get; set;}

    public DateOnly Date {get; set;} = DateOnly.FromDateTime(DateTime.Now);
}