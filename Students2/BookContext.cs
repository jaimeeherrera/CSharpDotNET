﻿// add the following imports to the top for your file
using Microsoft.EntityFrameworkCore;
using System.IO;

class StudentsContext : DbContext
{

    // This property corresponds to the table in our database
    public DbSet<Student> students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // get the directory the code is being executed from
        DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

        // get the base directory for the project
        DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

        // add 'students.db' to the project directory
        String DatabaseFile = Path.Combine(ProjectBase.FullName, "students.db");

        // to check what the path of the file is, uncomment the file below
        //Console.WriteLine("using database file :"+DatabaseFile);

        optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
    }
}