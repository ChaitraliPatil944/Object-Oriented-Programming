# Lesson 6 — Characteristics of Object-Oriented Programming

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Object-Oriented Programming (OOP) is more than just classes and objects. It is a programming paradigm built on a set of characteristics that help developers design software that is modular, reusable, scalable, and easy to maintain.

These characteristics make OOP the preferred choice for enterprise applications such as banking systems, e-commerce platforms, hospital management systems, and ERP software.

---

# 2. Core Characteristics of OOP

The major characteristics are:

```text
                OOP
                 │
 ┌───────────────┼────────────────┐
 │               │                │
 ▼               ▼                ▼
Objects      Classes        Encapsulation
 │               │                │
 ├───────────────┼────────────────┤
 ▼               ▼                ▼
Abstraction  Inheritance   Polymorphism
 │
 ▼
Modularity
 │
 ▼
Reusability
```

---

# 3. Objects

An object represents a real-world entity.

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

An object has:
- Identity
- State
- Behavior

---

# 4. Classes

A class is a blueprint for creating objects.

```java
class Car {

    String brand;
    int speed;

    void start() {}
}
```

Objects are instances of a class.

---

# 5. Encapsulation

Encapsulation means wrapping data and methods together into a single unit while restricting direct access to the data.

Example:

```java
class BankAccount {

    private double balance;

    public void deposit(double amount){
        balance += amount;
    }

    public double getBalance(){
        return balance;
    }
}
```

Benefits:
- Data security
- Validation
- Controlled access

---

# 6. Abstraction

Abstraction hides implementation details and exposes only essential functionality.

Example:

```java
interface Payment {

    void pay(double amount);
}
```

Users only know **what** the object does, not **how** it does it.

---

# 7. Inheritance

Inheritance allows one class to acquire properties and behavior of another.

```java
class Vehicle {

    void start(){}
}

class Car extends Vehicle {

}
```

Benefits:
- Code reuse
- Reduced duplication
- Easier maintenance

---

# 8. Polymorphism

Polymorphism allows one interface to have multiple implementations.

```java
class Animal {

    void sound(){
        System.out.println("Animal Sound");
    }
}

class Dog extends Animal {

    @Override
    void sound(){
        System.out.println("Bark");
    }
}
```

The same method behaves differently depending on the object.

---

# 9. Modularity

Large software is divided into independent modules.

Example:

```text
Customer Module

Order Module

Payment Module

Inventory Module
```

Each module focuses on a specific responsibility.

---

# 10. Reusability

Once a class is developed, it can be reused in multiple applications.

Example:

```text
Employee

↓

HRMS

Payroll

Attendance

Recruitment
```

---

# 11. Scalability

OOP allows applications to grow without major redesign.

Example:

```text
Vehicle

↓

Car

Bike

Truck

ElectricCar
```

New classes can be added with minimal changes.

---

# 12. Maintainability

Business requirements change frequently.

Because classes are modular, developers can modify one class without affecting the entire application.

---

# 13. Enterprise Example

Online Shopping System

```text
Customer
     │
     ▼
Cart
     │
     ▼
Order
     │
     ▼
Payment
     │
     ▼
Invoice
```

Each object is responsible for its own data and behavior.

---

# 14. Summary Table

| Characteristic | Purpose |
|---------------|---------|
| Object | Represents real-world entity |
| Class | Blueprint for objects |
| Encapsulation | Protects data |
| Abstraction | Hides complexity |
| Inheritance | Reuses code |
| Polymorphism | Provides flexibility |
| Modularity | Organizes software |
| Reusability | Saves development time |
| Scalability | Supports growth |
| Maintainability | Simplifies updates |

---

# Interview Questions

1. What are the characteristics of OOP?
2. Why are classes and objects important?
3. How do encapsulation and abstraction differ?
4. Why is polymorphism useful?
5. How do these characteristics help enterprise applications?

---

# Summary

The characteristics of OOP work together to build software that is secure, reusable, modular, maintainable, and scalable. Understanding these characteristics is essential before exploring each OOP concept in depth in the upcoming lessons.
