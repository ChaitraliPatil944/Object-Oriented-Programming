

namespace LMSApp.Managers;
using LMSApp.Entities;
public class InstructorManager
{
    private List<Instructor> instructors;

    public InstructorManager()
    {
        instructors = new List<Instructor>();
    }

    //Compile time polymorphism - method overloading
    public void AddInstructor(Instructor instructor)
    {
        if (!instructors.Contains(instructor))
        {
            instructors.Add(instructor);
        }
    }

    public void AddInstructor(string name)
    {
        int newId = instructors.Count + 1; // Simple ID generation
        Instructor newInstructor = new Instructor(newId, name);
        AddInstructor(newInstructor);
    }

    public void RemoveInstructor(Instructor instructor)
    {
        if (instructors.Contains(instructor))
        {
            instructors.Remove(instructor);
        }
    }

    public List<Instructor> GetAllInstructors()
    {
        return instructors;
    }

    public Instructor GetInstructorById(int id)
    {
        foreach (var instructor in instructors)
        {
            if (instructor.Id == id)
            {
                return instructor;
            }
        }
        throw new ArgumentException("Instructor not found.");
    }
}