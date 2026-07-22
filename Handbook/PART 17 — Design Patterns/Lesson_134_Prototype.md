# Lesson 134 — Prototype Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Prototype Pattern** is a creational design pattern that creates new objects by **cloning existing objects** instead of constructing them from scratch.

It is useful when object creation is expensive or complex.

---

# 2. Problem

Suppose creating an object requires:

- Database queries
- Network calls
- Large configuration
- Complex initialization

Creating the same object repeatedly wastes time and resources.

```text
Create Object
      │
Expensive Initialization
      │
Ready Object
```

---

# 3. Solution

Create one fully initialized object and clone it whenever another similar object is needed.

```text
Original Object
       │
     Clone
       │
 New Object
```

---

# 4. Prototype Interface

Java commonly uses the `Cloneable` interface.

```java
class Student implements Cloneable {
}
```

---

# 5. Example

```java
class Student implements Cloneable {

    String name;
    int age;

    @Override
    protected Student clone() throws CloneNotSupportedException {
        return (Student) super.clone();
    }
}
```

Usage:

```java
Student s1 = new Student();

Student s2 = s1.clone();
```

---

# 6. How It Works

```text
Client
   │
Existing Object
   │
clone()
   │
Copy Returned
```

The clone starts with the same state as the original.

---

# 7. Shallow Copy

Copies primitive values and object references.

```text
Student
   │
Address
```

Both cloned objects reference the same `Address` object.

Changes to shared referenced objects affect both.

---

# 8. Deep Copy

Creates independent copies of referenced objects.

```text
Student
   │
Address Copy
```

Each clone owns its own nested objects.

---

# 9. Advantages

- Faster object creation
- Reduces initialization cost
- Simplifies copying complex objects
- Supports runtime object duplication

---

# 10. Disadvantages

- Deep copying can be difficult.
- Cloning complex object graphs requires care.
- Shared references may introduce bugs if shallow copies are used accidentally.

Because duplicating an object is easy. Duplicating it *correctly* is where software quietly develops trust issues.

---

# 11. Real-World Uses

- Game object creation
- Graphic editors
- Document templates
- Configuration objects
- Cached object duplication

---

# 12. Prototype vs Builder

| Prototype | Builder |
|-----------|---------|
| Copies existing object | Builds new object |
| Fast duplication | Step-by-step construction |
| Useful for expensive initialization | Useful for many optional fields |

---

# 13. Prototype vs Factory

| Prototype | Factory |
|-----------|---------|
| Clones an existing object | Creates a fresh object |
| Existing instance required | Uses creation logic |

---

# 14. Best Practices

- Implement deep copy when mutable references exist.
- Document cloning behavior clearly.
- Prefer copy constructors or factory methods if cloning becomes confusing.
- Test cloned objects independently.

---

# 15. Interview Questions

1. What is the Prototype pattern?
2. When should Prototype be used?
3. Shallow copy vs deep copy?
4. Why is cloning sometimes faster than construction?
5. What are the drawbacks of `Cloneable`?

---

# 16. Quick Revision

```text
Prototype Pattern

✔ Clone Existing Objects
✔ Faster Creation
✔ Reuse Initialization

Copy Types

Shallow Copy
Deep Copy
```

---

# 17. Summary

The Prototype pattern creates new objects by cloning existing ones instead of constructing them from scratch. It is valuable when object creation is expensive or when many similar objects are required. Understanding shallow and deep copying is essential for using this pattern correctly in real-world applications.
