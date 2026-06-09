
namespace LMSApp.Entities;
 
public class Instructor : Person
{
    public List<Course> Courses { get; set; }

    public Instructor(int id, string name) : base( id, name)
    {
        Courses = new List<Course>();
    }


    public void AssignCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            course.Instructor = this;
        }
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Instructor ID: {Id}, Name: {Name}");
        Console.WriteLine("Courses taught:");
        foreach (var course in Courses)
        {
            Console.WriteLine($"- {course.Title}");
        }
    }

}


