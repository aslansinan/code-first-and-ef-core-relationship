// See https://aka.ms/new-console-template for more information
using EfCoreConsole.Models;

Console.WriteLine("Hello, World!");
using (var context = new SchoolContext())
{
    var std = new Student()
    {
        StudentName = "Bill"
    };
    context.Students.Add(std);

    // or
    // context.Add<Student>(std);

    context.SaveChanges();
}

