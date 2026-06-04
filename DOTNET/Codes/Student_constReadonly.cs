class Student {
    public const string SchoolName = "Mukatangan English School";
    readonly string studentName;
    readonly int rollNumber;

    public Student(string name , int rollNo){
        studentName = name;
        rollNumber = rollNo;
    }
    public void DisplayDetails(){
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine($"School Name: {SchoolName}");
    
    }
}
    class MainClass {
        public static void Main(string[] args) {
            Student student1 = new Student("Chait", 101);
            student1.DisplayDetails();
            Student student2 = new Student("Arnav", 102);
            student2.DisplayDetails();
            Console.WriteLine(Student.SchoolName); // Implicitly static, can be accessed without an instance
        }
    }
