namespace StudentSearcher.Data;

public class Student
{
    public int StudentID { get; set; } // TEMP: Auto-incremenet to be implemented
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; } = "Eagle Rock"; // TEMP: Placeholder city
    public string? State { get; set; } = "CA"; // TEMP: State abbrev. to be implemented
    public int ZIPCode { get; set; } = 99999;
    public int SchoolCode { get; set; } = 994;
}