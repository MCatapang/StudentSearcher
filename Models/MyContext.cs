#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace StudentSearcher.Models;

public class MyContext : DbContext
{
    public MyContext() { }
    public MyContext(DbContextOptions<MyContext> options) : base(options) { }

    /* 
        Logic for Student primary key incrementation.
        Unfinished due to SQL Syntax Error in
            '.HasComputedColumnSql()' method.
    */
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Student>()
    //         .Property(s => s.StudentID)
    //         .HasComputedColumnSql("CONCAT('prefix', [StudentID];");
    // }
    
    // Refer to StudentSearcherDB on MySQL
    public DbSet<Student> Students { get; set; }
    public DbSet<Contact> Contacts { get; set; }
}