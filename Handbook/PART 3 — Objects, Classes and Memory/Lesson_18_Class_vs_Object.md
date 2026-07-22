# Lesson 18 — Class vs Object

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of the first concepts every Java developer learns is the difference between a **class** and an **object**. Although they are closely related, they are not the same.

A class defines **what** an entity should look like, while an object represents a **real instance** of that definition.

Understanding this distinction is fundamental to Object-Oriented Programming.

---

# 2. What is a Class?

A **class** is a blueprint or template that describes:

- Data (fields)
- Behavior (methods)

A class itself does not occupy heap memory as an object does. It serves as a design from which objects are created.

Example:

```java
class Student {

    int rollNo;
    String name;

    void study() {
        System.out.println(name + " is studying.");
    }
}
```

---

# 3. What is an Object?

An **object** is a runtime instance of a class.

Objects contain actual values for the fields defined by the class.

Example:

```java
Student s1 = new Student();

s1.rollNo = 101;
s1.name = "Alice";
```

Here, `s1` refers to an actual Student object stored in heap memory.

---

# 4. Blueprint vs Building

A common analogy is:

```text
Blueprint (Class)
        │
        ▼
Construct Building (Object)

House Plan
        │
        ▼
Actual House
```

The blueprint can be reused to construct many buildings.

Similarly, one class can create many objects.

---

# 5. Memory Representation

```text
Stack

student
   │
   ▼

Heap

+----------------------+
| Student Object       |
| rollNo = 101         |
| name = Alice         |
+----------------------+
```

The reference variable is stored on the stack, while the object is stored on the heap.

---

# 6. Multiple Objects from One Class

```java
Student s1 = new Student();
Student s2 = new Student();
Student s3 = new Student();
```

```text
Student Class
      │
 ┌────┼────┐
 ▼    ▼    ▼
s1   s2   s3
```

Each object has independent data.

---

# 7. Class vs Object Comparison

| Feature | Class | Object |
|---------|-------|--------|
| Definition | Blueprint | Instance |
| Exists | Before objects | Created at runtime |
| Memory | Class metadata managed by JVM | Heap memory |
| Data | Declares fields | Stores field values |
| Behavior | Declares methods | Uses methods |
| Quantity | One class | Many objects |

---

# 8. Real-World Example

### Banking System

Class:

```text
BankAccount
```

Objects:

```text
Account #1001

Account #1002

Account #1003
```

All accounts follow the same structure but store different balances and customer details.

---

# 9. Java Example

```java
class Car {

    String brand;

    void start() {
        System.out.println(brand + " started.");
    }
}

public class Main {

    public static void main(String[] args) {

        Car c1 = new Car();
        Car c2 = new Car();

        c1.brand = "BMW";
        c2.brand = "Audi";

        c1.start();
        c2.start();
    }
}
```

Output:

```text
BMW started.
Audi started.
```

Both objects share the same class but have different states.

---

# 10. Common Misconceptions

❌ A class is an object.

❌ Objects automatically share all data.

❌ A class can store runtime values.

Correct understanding:

- A class defines structure.
- Objects hold actual data.
- Every object has its own state.

---

# 11. Best Practices

- Design small, focused classes.
- Create objects only when needed.
- Avoid classes with too many responsibilities.
- Model real-world entities clearly.

---

# 12. Interview Questions

1. What is the difference between a class and an object?
2. Can a class exist without objects?
3. Can objects exist without a class?
4. Where are classes and objects stored in memory?
5. Why can one class create multiple objects?

---

# 13. Summary

A class is a blueprint that defines the structure and behavior of an entity, while an object is a real runtime instance of that blueprint. A single class can create many objects, each with its own state, making Object-Oriented Programming reusable, scalable, and easy to model for real-world applications.
