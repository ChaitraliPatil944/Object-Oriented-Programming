
namespace LMSApp.Entities;
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public Instructor Instructor { get; set; }
    public List<Student> Students { get; set; }
    public int Duration{ get; set; } // Duration in hours

    public Course(int id, string title, int duration)
    {
        Id = id;
        Title = title;
        Duration = duration;
        Students = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (!Students.Contains(student))
        {
            Students.Add(student);
            student.EnrollInCourse(this);
        }
    }
}