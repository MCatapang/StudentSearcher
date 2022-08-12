#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace StudentSearcher.Models;

public class DAL
{
    MyContext db = new MyContext();

    public DAL()
    {
        db = new MyContext();
    }

    public List<Student> GetStudents()
    {
        return db.Students.ToList();
    }
}