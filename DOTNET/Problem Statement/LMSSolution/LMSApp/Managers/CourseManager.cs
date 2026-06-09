

namespace LMSApp.Managers;
using LMSApp.Entities;
public class CourseManager
{
    private List<Course> courses;

    public CourseManager()
    {
        courses = new List<Course>();
    }

    //Compile time polymorphism - method overloading
    public void AddCourse(Course course)
    {
        if (!courses.Contains(course))
        {
            courses.Add(course);
        }
    }

    public void AddCourse(string title, int duration)
    {
        int newId = courses.Count + 1; // Simple ID generation
        Course newCourse = new Course(newId, title, duration);
        AddCourse(newCourse);
    }

    public void RemoveCourse(Course course)
    {
        if (courses.Contains(course))
        {
            courses.Remove(course);
        }
    }

    public List<Course> GetAllCourses()
    {
        return courses;
    }

    public Course GetCourseById(int id)
    {
        foreach (var course in courses)
        {
            if (course.Id == id)
            {
                return course;
            }
        }
        throw new ArgumentException("Course not found.");
    }
}