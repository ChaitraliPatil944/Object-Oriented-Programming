using System;
using System.Collections.Generic;

public class Instructor : Person
{
    public List<Course> AssignedCourses { get; set; }

    public Instructor(int id, string name)
        : base(id, name)
    {
        AssignedCourses = new List<Course>();
    }

    public void AssignCourse(Course course)
    {
        AssignedCourses.Add(course);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Instructor ID: {Id}");
        Console.WriteLine($"Name: {Name}");

        Console.WriteLine("Assigned Courses:");

        foreach (Course c in AssignedCourses)
        {
            Console.WriteLine($" - {c.CourseName}");
        }
    }
}