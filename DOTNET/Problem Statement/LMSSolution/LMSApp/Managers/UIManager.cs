//Front End  (UI)
using LMSApp.Entities;


namespace LMSApp.Managers;
public class UIManager
{
         public void DisplayCourses()
        {
            CourseManager courseMgr=new CourseManager();
            List<Course> courses= courseMgr.GetAllCourses();
            foreach (var course in courses )
            {
                Console.WriteLine($"Course ID: {course.Id}, Title: {course.Title}, Duration: {course.Duration} hours");
            }
        }

        public void DisplayStudents()
        {
            StudentManager studentMgr=new StudentManager();
            List<Student> allStudents=studentMgr.GetAllStudents();

            foreach (var student in allStudents)
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}");
            }
        }

        public void DisplayInstructors()
        {
            InstructorManager instructorMgr=new InstructorManager();
            List<Instructor> allInstructors=instructorMgr.GetAllInstructors();


            foreach (var instructor in allInstructors)
            {
                Console.WriteLine($"Instructor ID: {instructor.Id}, Name: {instructor.Name}");
            }
        }
     
         //Method to display the main menu and handle user input.
        public void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Trassflower Learning Management System (LMS)");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Manage Courses");
            Console.WriteLine("2. Manage Students");
            Console.WriteLine("3. Manage Instructors");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            HandleMainMenuChoice(choice);
        }

        public void DisplayCourseMenu()
        {
            Console.WriteLine("Course Management");
            Console.WriteLine("1. Add Course");
            Console.WriteLine("2. Remove Course");
            Console.WriteLine("3. View All Courses");
            Console.WriteLine("4. Back to Main Menu");

            string choice = Console.ReadLine();
            HandleCourseMenuChoice(choice);
        }
     
        public void DisplayStudentMenu()
        {
            Console.WriteLine("Student Management");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. View All Students");
            Console.WriteLine("4. Back to Main Menu");

            string choice = Console.ReadLine();
            HandleStudentMenuChoice(choice);
        }

        public void DisplayInstructorMenu()
        {
            Console.WriteLine("Instructor Management");
            Console.WriteLine("1. Add Instructor");
            Console.WriteLine("2. Remove Instructor");
            Console.WriteLine("3. View All Instructors");
            Console.WriteLine("4. Back to Main Menu");

            string choice = Console.ReadLine();
            HandleInstructorMenuChoice(choice);
        }
        //Method to handle the user's choice from the main menu.
        public void HandleMainMenuChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    // Code to manage courses
                    Console.WriteLine("Course management is not implemented yet.");
                    break;
                case "2":
                    // Code to manage students
                    Console.WriteLine("Student management is not implemented yet.");
                    break;
                case "3":
                    // Code to manage instructors
                    Console.WriteLine("Instructor management is not implemented yet.");
                    break;
                case "4":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    DisplayMainMenu();
                    break;
            }
        }
        public void HandleCourseMenuChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    // Code to add a course
                    Console.WriteLine("Add course functionality is not implemented yet.");
                    break;
                case "2":
                    // Code to remove a course
                    Console.WriteLine("Remove course functionality is not implemented yet.");
                    break;
                case "3":
                    DisplayCourses();
                    break;
                case "4":
                    DisplayMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    DisplayCourseMenu();
                    break;
            }
        }
        public void HandleStudentMenuChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    // Code to add a student
                    Console.WriteLine("Add student functionality is not implemented yet.");
                    break;
                case "2":
                    // Code to remove a student
                    Console.WriteLine("Remove student functionality is not implemented yet.");
                    break;
                case "3":
                    DisplayStudents();
                    break;
                case "4":
                    DisplayMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    DisplayStudentMenu();
                    break;
            }
        }
        public void HandleInstructorMenuChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    // Code to add an instructor
                    Console.WriteLine("Add instructor functionality is not implemented yet.");
                    break;
                case "2":
                    // Code to remove an instructor
                    Console.WriteLine("Remove instructor functionality is not implemented yet.");
                    break;
                case "3":
                    DisplayInstructors();
                    break;
                case "4":
                    DisplayMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    DisplayInstructorMenu();
                    break;
            }
        }
}