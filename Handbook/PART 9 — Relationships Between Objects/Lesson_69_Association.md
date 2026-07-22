# Lesson 69 — Association

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Association** is a relationship between two independent objects where one object uses or interacts with another.

It is one of the most basic relationships in Object-Oriented Programming and represents a **"knows-a"** relationship.

Unlike inheritance, both objects have their own lifecycle.

---

# 2. Definition

Association is a relationship in which one class is connected to another class to perform a task.

Characteristics:

- Independent objects
- No ownership
- Objects can exist separately
- Can be one-to-one, one-to-many, or many-to-many

---

# 3. Real-World Example

```text
Student -------- Teacher

A student learns from a teacher.

Both can exist independently.
```

If a teacher leaves the school, the student still exists.

---

# 4. Java Example

```java
class Teacher {

    String name;

    Teacher(String name) {
        this.name = name;
    }
}

class Student {

    String name;
    Teacher teacher;

    Student(String name, Teacher teacher) {
        this.name = name;
        this.teacher = teacher;
    }

    void display() {
        System.out.println(name + " learns from " + teacher.name);
    }
}
```

Usage:

```java
Teacher teacher = new Teacher("Dr. Rao");
Student student = new Student("Anita", teacher);

student.display();
```

Output:

```
Anita learns from Dr. Rao
```

---

# 5. Types of Association

### One-to-One

```text
Person ---- Passport
```

### One-to-Many

```text
Teacher ---- Students
```

### Many-to-Many

```text
Student ---- Courses
```

---

# 6. Association in Enterprise Applications

Examples:

- Customer ↔ Bank
- Doctor ↔ Patient
- User ↔ Role
- Employee ↔ Department
- Student ↔ Course

These objects collaborate but remain independent.

---

# 7. Advantages

- Promotes code reuse
- Improves modularity
- Supports collaboration between objects
- Reduces tight coupling

---

# 8. Best Practices

- Keep relationships meaningful.
- Avoid unnecessary bidirectional associations.
- Use interfaces where possible.
- Maintain loose coupling.

---

# 9. Common Mistakes

❌ Confusing association with inheritance.

❌ Assuming one object owns the other.

❌ Creating unnecessary object dependencies.

---

# 10. Interview Questions

1. What is association?
2. Is association a "has-a" relationship?
3. Can associated objects exist independently?
4. Difference between association and aggregation?
5. Give real-world examples of association.

---

# 11. Quick Revision

```text
Association
│
├── Independent objects
├── Uses another object
├── No ownership
├── Knows-a relationship
└── Loose coupling
```

---

# 12. Summary

Association is a fundamental object relationship where two independent objects interact without owning each other. It models real-world collaborations such as Student-Teacher or Customer-Bank and is widely used in enterprise software to build modular, loosely coupled systems.
