#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace StudentSearcher.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; } 
    // See 'MyContext.cs' for unfinished incrementation logic

    [Required]
    [MinLength(2)]
    [MaxLength(15)]
    public string LastName { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(15)]
    public string FirstName { get; set; }

    [Required]
    [MinLength(5)]
    [MaxLength(35)]
    public string Address { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(28)]
    public string City { get; set; } = "Eagle Rock"; // TEMP: Placeholder city

    [Required]
    [MinLength(2)]
    [MaxLength(2)]
    public string State { get; set; } = "CA"; // TEMP: State abbrev. to be implemented

    [Required]
    [Range(00501,99999)]
    public int ZIPCode { get; set; } = 99999;

    [Required]
    [Range(100, 999)]
    public int SchoolCode { get; set; } = 994;

    // One-to-Many
    public List<Contact> Contacts { get; set; } = new List<Contact>();
}