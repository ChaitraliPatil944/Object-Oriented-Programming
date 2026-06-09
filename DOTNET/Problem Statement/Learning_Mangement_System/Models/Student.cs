using System;
using System.Collections.Generic;

public class Student : Person
{
    public List<Course> EnrolledCourses { get; set; }

    public Student(int id, string name): base(id, name)
    {
        EnrolledCourses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        EnrolledCourses.Add(course);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {Id}");
        Console.WriteLine($"Name: {Name}");

        Console.WriteLine("Courses:");

        foreach (Course c in EnrolledCourses)
        {
            Console.WriteLine($" - {c.CourseName}");
        }
    }
}