#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace StudentSearcher.Models;

public class Contact
{
    [Key]
    public int ContactID { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(15)]
    public string LastName { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(15)]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(15)]
    public string Relationship { get; set; }

    [Required]
    [MinLength(3)]
    public string EmailAddress { get; set; }

    [Required]
    public string MobileNumber { get; set; } // TEMP: Formatting to be implemented

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
    [Range(00501, 99999)]
    public int ZIPCode { get; set; } = 99999;

    // Many-to-One
    public int StudentID { get; set; }
    public Student? Student { get; set; }
}