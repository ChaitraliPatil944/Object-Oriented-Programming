##  Problem Statement: Console-Based LMS Core Engine with Menu-Driven UI (C# OOP + Design Patterns)

##  Objective
Design and implement a **menu-driven console application** for a simplified **Learning Management System (LMS)** using **C# and Object-Oriented Programming concepts**.

The system must demonstrate real-world usage of:
* Classes and Objects
* Inheritance and Abstraction
* Interfaces and Loose Coupling
* Polymorphism (Compile-time + Runtime)
* Singleton Design Pattern
* Collections (`List<T>`)
* Menu-driven user interaction


##  System Context
A training institute wants to manage its basic academic operations through a console system. Instead of a database-driven application, you will simulate the system using **in-memory collections** and **OOP-based architecture**.

The system should behave like a small backend engine where users can manage:
* Students
* Instructors
* Courses
* Enrollments
* Notifications

#  Functional Requirements

##  1. Menu-Driven Interface (MANDATORY)
Your application must continuously display the following menu:

```
========= LMS MAIN MENU =========
1. Add Student
2. Add Instructor
3. Add Course
4. Enroll Student in Course
5. Assign Instructor to Course
6. View All Students
7. View All Instructors
8. View All Courses
9. Send Notification
10. Show System Configuration (Singleton)
11. Exit
=================================
```

The program should run in a loop until the user selects **Exit**.

#  2. Core Class Design (OOP Requirement)
## 🔹 Abstract Class: Person

* Id
* Name
* Abstract method: `DisplayInfo()`

### Derived Classes:
###  Student

* List of enrolled courses
* Methods:

  * EnrollCourse()
  * DisplayInfo() override

###  Instructor
* List of assigned courses
* Methods:
  * AssignCourse()
  * DisplayInfo() override

##  Course Class
* CourseId
* CourseName
* Duration
* AssignedInstructor

#  3. Interface Design (Loose Coupling)


## INotificationService

Method:

* `SendNotification(string message)`

### Implementations:

* EmailNotificationService
* SmsNotificationService

👉 User should be able to choose notification type from menu.



#  4. Polymorphism Requirement


## Compile-Time Polymorphism
* Method overloading in Course operations (e.g., AddCourse with different parameters)


## Runtime Polymorphism (MANDATORY)

Use base class reference:

```csharp id="lms_poly_example"
Person p = new Student();
p.DisplayInfo();
```

Also:

* Maintain `List<Person>`
* Iterate and call `DisplayInfo()` dynamically

#  5. Singleton Pattern (MANDATORY)
##  LMSConfigurationManager
This class must:
* Follow Singleton design pattern
* Store system-wide settings:

  * Institute Name
  * Version
  * Admin Contact

### Requirements:
* Private constructor
* Static instance
* Global access method

👉 Menu Option 10 should display this configuration.

#  6. Functional Behavior Requirements
## 1. Add Student
* Accept student details
* Store in `List<Student>`

## 2. Add Instructor
* Store in `List<Instructor>`

## 3. Add Course
* Store in `List<Course>`

## 4. Enroll Student in Course
* Select student and course
* Add course to student list

## 5. Assign Instructor
* Link instructor to course


## 6–8. View Operations
Display all stored data using:
* Polymorphism (`DisplayInfo()`)


## 9. Send Notification
User must:
* Select notification type:
  * Email
  * SMS
* Enter message
* Call appropriate service using interface reference

## 10. Show Configuration
Display Singleton object data:
* Institute Name
* Version
* Admin Contact

#  7. System Constraints
* Use **only in-memory storage (List<T>)**
* No database required
* Use proper OOP structure
* Avoid writing logic in Main directly (use classes/services)

#  8. Required OOP Demonstrations
Your solution MUST demonstrate:

### ✔ Inheritance
Student, Instructor → Person

### ✔ Abstraction
Abstract class Person
Separation of concern
Essential Characteristics depending on perspective of observer


### ✔ Polymorphism
* DisplayInfo override
* Base class references in collections

### ✔ Interfaces
Notification system

### ✔ Singleton
LMSConfigurationManager


# 9. Bonus Features (Advanced Students)
* Delete Student / Course
* Search Student by ID
* Course capacity validation
* Exception handling for invalid inputs
* Logger Singleton class
* Role-based menu (Admin vs User)


#  Learning Outcomes
After completing this assignment, students will:
* Build real-world system thinking using OOP
* Understand menu-driven application design
* Apply polymorphism in runtime scenarios
* Design loosely coupled systems using interfaces
* Implement Singleton pattern correctly
* Transition from syntax-based coding → architecture-based thinking