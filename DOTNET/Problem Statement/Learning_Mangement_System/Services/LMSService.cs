using System;
using System.Collections.Generic;

public class LMSService
{
    public List<Student> Students = new();
    public List<Instructor> Instructors = new();
    public List<Course> Courses = new();

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddInstructor(Instructor instructor)
    {
        Instructors.Add(instructor);
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void EnrollStudent(int studentId, int courseId)
    {
        Student student =
            Students.Find(s => s.Id == studentId);

        Course course =
            Courses.Find(c => c.CourseId == courseId);

        if(student != null && course != null)
        {
            student.EnrollCourse(course);
            Console.WriteLine("Enrollment Successful");
        }
    }

    public void AssignInstructor(
        int instructorId,
        int courseId)
    {
        Instructor instructor =
            Instructors.Find(i => i.Id == instructorId);

        Course course =
            Courses.Find(c => c.CourseId == courseId);

        if(instructor != null && course != null)
        {
            instructor.AssignCourse(course);
            course.AssignedInstructor = instructor;

            Console.WriteLine("Instructor Assigned");
        }
    }
}