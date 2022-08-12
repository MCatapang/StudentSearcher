namespace StudentSearcher.Data;

public class Contact
{
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Relationship { get; set; }
    public string? EmailAddress { get; set; }
    public string? MobileNumber { get; set; } // TEMP: Formatting to be implemented
    public string? Address { get; set; }
    public string? City { get; set; } = "Eagle Rock"; // TEMP: Placeholder city
    public string? State { get; set; } = "CA"; // TEMP: State abbrev. to be implemented
    public int ZIPCode { get; set; } = 99999;
    public int StudentID { get; set; } // TEMP: Auto-incremenet to be implemented
}