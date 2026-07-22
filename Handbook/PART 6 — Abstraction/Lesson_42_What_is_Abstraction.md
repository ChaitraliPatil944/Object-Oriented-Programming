# Lesson 42 — What is Abstraction?

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Abstraction** is one of the four fundamental principles of Object-Oriented Programming (OOP).

Abstraction focuses on **showing only the essential features of an object while hiding unnecessary implementation details**.

Instead of worrying about *how* something works internally, users only need to know *what* it does.

---

# 2. Definition

**Abstraction** is the process of exposing only the relevant functionality of an object while hiding its internal implementation.

```text
User
  │
  ▼
Visible Features
(Start, Stop, Accelerate)
  │
  ▼
Hidden Implementation
(Engine, Fuel Injection, ECU)
```

The user interacts with the interface, not the internal complexity.

---

# 3. Why is Abstraction Needed?

Without abstraction:

- Applications become difficult to use.
- Internal implementation is exposed.
- Changing implementation affects users.
- Code becomes tightly coupled.

Abstraction reduces complexity by exposing only what is necessary.

---

# 4. Real-World Example

Consider driving a car.

```text
Driver
   │
   ▼
Steering Wheel
Brake
Accelerator
Gear

Hidden:
Engine
Transmission
Fuel System
Cooling System
```

The driver operates the car without understanding every internal component.

---

# 5. Abstraction in Java

Java achieves abstraction using:

- Abstract classes
- Interfaces

Example:

```java
abstract class Animal {

    abstract void sound();
}
```

Subclasses provide the implementation.

---

# 6. Example

```java
abstract class Shape {

    abstract double area();
}

class Circle extends Shape {

    double radius;

    Circle(double radius){
        this.radius = radius;
    }

    double area(){
        return Math.PI * radius * radius;
    }
}
```

The user calls `area()` without knowing how each shape calculates it.

---

# 7. Abstraction vs Encapsulation

| Abstraction | Encapsulation |
|--------------|--------------|
| Hides implementation | Hides data |
| Focuses on what an object does | Focuses on protecting object state |
| Achieved using abstract classes and interfaces | Achieved using access modifiers and classes |

They complement each other but solve different problems.

---

# 8. Benefits of Abstraction

- Reduces complexity
- Improves maintainability
- Encourages loose coupling
- Makes code reusable
- Supports polymorphism
- Simplifies large systems

---

# 9. Enterprise Example

Consider an online payment application.

```text
Customer
     │
     ▼
Pay()
     │
     ▼
Payment Gateway

Internal Steps:
---------------
Authentication
Encryption
Bank Communication
Fraud Detection
Transaction Logging
```

The customer only interacts with the `pay()` operation.

---

# 10. UML Representation

```text
        <<abstract>>
        +----------------+
        |     Shape      |
        +----------------+
        | + area()       |
        +----------------+
              ▲
      ┌───────┴────────┐
      ▼                ▼
+-------------+   +-------------+
|   Circle    |   | Rectangle   |
+-------------+   +-------------+
| + area()    |   | + area()    |
+-------------+   +-------------+
```

---

# 11. Common Misconceptions

❌ Abstraction and encapsulation are the same.

❌ Abstraction hides data.

❌ Every abstract class must contain only abstract methods.

Correct understanding:

- Abstraction hides implementation.
- Encapsulation protects data.
- Abstract classes may contain both abstract and concrete methods.

---

# 12. Best Practices

- Design around behavior, not implementation.
- Keep interfaces simple.
- Hide unnecessary complexity.
- Use abstraction to reduce coupling.
- Expose only meaningful operations.

---

# 13. Interview Questions

1. What is abstraction?
2. Why is abstraction important?
3. How is abstraction implemented in Java?
4. What is the difference between abstraction and encapsulation?
5. Give a real-world example of abstraction.
6. Can an abstract class contain concrete methods?

---

# 14. Summary

Abstraction is the process of exposing essential functionality while hiding implementation details. It allows developers to design systems that are easier to understand, maintain, and extend. Java supports abstraction through abstract classes and interfaces, enabling applications to focus on behavior rather than implementation details. Abstraction is a key principle behind scalable enterprise software and flexible object-oriented design.
