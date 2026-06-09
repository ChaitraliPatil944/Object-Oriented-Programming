namespace LMSApp.Entities;
 
    //Base class for all people in the LMS (students, instructors).
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        protected Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void DisplayInfo();
    }