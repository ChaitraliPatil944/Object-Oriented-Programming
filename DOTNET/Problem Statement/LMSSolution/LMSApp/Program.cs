using System;

class Program
{
    static void Main()
    {
        LMSService service = new LMSService();

        while(true)
        {
            Console.WriteLine("\n========= LMS MAIN MENU =========");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Instructor");
            Console.WriteLine("3. Add Course");
            Console.WriteLine("4. Enroll Student in Course");
            Console.WriteLine("5. Assign Instructor to Course");
            Console.WriteLine("6. View All Students");
            Console.WriteLine("7. View All Instructors");
            Console.WriteLine("8. View All Courses");
            Console.WriteLine("9. Send Notification");
            Console.WriteLine("10. Show Configuration");
            Console.WriteLine("11. Exit");
            Console.WriteLine("=================================");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.Write("Student Id: ");
                    int sid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Student Name: ");
                    string sname = Console.ReadLine();

                    service.AddStudent(
                        new Student(sid,sname));

                    break;

                case 2:
                    Console.Write("Instructor Id: ");
                    int iid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Instructor Name: ");
                    string iname = Console.ReadLine();

                    service.AddInstructor(
                        new Instructor(iid,iname));

                    break;

                case 3:

                    Console.Write("Course Id: ");
                    int cid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Course Name: ");
                    string cname = Console.ReadLine();

                    Console.Write("Duration: ");
                    int duration =
                        Convert.ToInt32(Console.ReadLine());

                    service.AddCourse(
                        new Course(cid,cname,duration));

                    break;

                case 4:

                    Console.Write("Student Id: ");
                    sid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Course Id: ");
                    cid = Convert.ToInt32(Console.ReadLine());

                    service.EnrollStudent(sid,cid);

                    break;

                case 5:

                    Console.Write("Instructor Id: ");
                    iid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Course Id: ");
                    cid = Convert.ToInt32(Console.ReadLine());

                    service.AssignInstructor(iid,cid);

                    break;

                case 6:

                    foreach(Student s in service.Students)
                    {
                        s.DisplayInfo();
                    }

                    break;

                case 7:

                    foreach(Instructor i in service.Instructors)
                    {
                        i.DisplayInfo();
                    }

                    break;

                case 8:

                    foreach(Course c in service.Courses)
                    {
                        Console.WriteLine(
                            $"{c.CourseId} | {c.CourseName} | {c.Duration} Hours");
                    }

                    break;

                case 9:

                    Console.WriteLine("1. Email");
                    Console.WriteLine("2. SMS");

                    int type =
                        Convert.ToInt32(Console.ReadLine());

                    Console.Write("Message: ");
                    string msg = Console.ReadLine();

                    INotificationService serviceObj;

                    if(type == 1)
                    {
                        serviceObj =
                            new EmailNotificationService();
                    }
                    else
                    {
                        serviceObj =
                            new SmsNotificationService();
                    }

                    serviceObj.SendNotification(msg);

                    break;

                case 10:

                    LMSConfigurationManager config =
                        LMSConfigurationManager.GetInstance();

                    Console.WriteLine(config.InstituteName);
                    Console.WriteLine(config.Version);
                    Console.WriteLine(config.AdminContact);

                    break;

                case 11:
                    return;
            }
        }
    }
}