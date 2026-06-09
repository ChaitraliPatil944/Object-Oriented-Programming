namespace LMSApp.Managers;
using LMSApp.Entities;
public class StudentManager
{
    private List<Student> students;

    public StudentManager()
    {
        students = new List<Student>();
    }

    //Compile time polymorphism - method overloading
    public void AddStudent(Student student)
    {
        if (!students.Contains(student))
        {
            students.Add(student);
        }
    }

    public void AddStudent(string name)
    {
        int newId = students.Count + 1; // Simple ID generation
        Student newStudent = new Student(newId, name);
        AddStudent(newStudent);
    }

    public void RemoveStudent(Student student)
    {
        if (students.Contains(student))
        {
            students.Remove(student);
        }
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }

    public Student GetStudentById(int id)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
            {
                return student;
            }
        }
        throw new ArgumentException("Student not found.");
    }
}