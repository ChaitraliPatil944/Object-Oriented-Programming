namespace LMSApp.Entities
{
 public class Student : Person
    {
        public List<Course> EnrolledCourses { get; set; }

        public Student(int id, string name) : base(id, name)
        {
            EnrolledCourses = new List<Course>();
        }

        public void EnrollInCourse(Course course)
        {
            if (!EnrolledCourses.Contains(course))
            {
                EnrolledCourses.Add(course);
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}");
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine($"- {course.Title}");
            }
        }
    }
}