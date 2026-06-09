
namespace LMSApp.Handlers;
using LMSApp.Managers;
using LMSApp.Entities;

public class CoursesHandler
{
    private CourseManager courseManager;

    public CoursesHandler(CourseManager courseManager)
    {
        this.courseManager = courseManager;
    }

    public void AddCourse(string title, int duration)
    {
        courseManager.AddCourse(title, duration);
    }

    public void RemoveCourse(int id)
    {
        Course course = courseManager.GetCourseById(id);
        courseManager.RemoveCourse(course);
    }

    public List<Course> GetAllCourses()
    {
        return courseManager.GetAllCourses();
    }

    public Course GetCourseById(int id)
    {
        return courseManager.GetCourseById(id);
    }

    public void  HandleCoursMenuOperations(int choice)
    {
        switch (choice)
        {
            //Add Course
            case 1:
                Console.Write("Enter course title: ");
                string title = Console.ReadLine();
                Console.Write("Enter course duration (in hours): ");
                int duration = int.Parse(Console.ReadLine());
                AddCourse(title, duration);
                Console.WriteLine("Course added successfully.");
                break;

            //Remove Course
            case 2:
                Console.Write("Enter course ID to remove: ");
                int idToRemove = int.Parse(Console.ReadLine());
                RemoveCourse(idToRemove);
                Console.WriteLine("Course removed successfully.");
                break;

            //Display Courses
            case 3:
                {
                     List<Course> courses = GetAllCourses();
                Console.WriteLine("Courses:");
                foreach (Course c in courses)
                {
                    Console.WriteLine($"ID: {c.Id}, Title: {c.Title}, Duration: {c.Duration} hours");
                } 
                }
               break;

            //Display Course Details
            case 4:
                {
                    Console.Write("Enter course ID to view details: ");
                    int idToView = int.Parse(Console.ReadLine());
                    Course course = GetCourseById(idToView);
                    Console.WriteLine($"ID: {course.Id}, Title: {course.Title}, Duration: {course.Duration} hours");
                }
                break;
            }
    }
}