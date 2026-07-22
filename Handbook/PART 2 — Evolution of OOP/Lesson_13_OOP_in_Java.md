# Lesson 13 — OOP in Java

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Java was designed by **James Gosling** at Sun Microsystems and officially released in **1995**. While C++ popularized Object-Oriented Programming, Java simplified it by removing many complex features and making OOP safer and easier to use for enterprise applications.

Java follows the philosophy:

> **Write Once, Run Anywhere (WORA)**

using the **Java Virtual Machine (JVM)**.

---

# 2. Why Java Was Created

C++ was powerful but had several challenges:

- Manual memory management
- Pointer arithmetic
- Multiple inheritance complexity
- Platform dependency

Java addressed these issues by introducing:

- Automatic Garbage Collection
- JVM
- Bytecode
- Strong type checking
- Simpler object model

---

# 3. Java Architecture

```text
Java Source Code (.java)
          │
          ▼
      Java Compiler (javac)
          │
          ▼
      Bytecode (.class)
          │
          ▼
     Java Virtual Machine (JVM)
          │
          ▼
      Operating System
```

This architecture enables platform independence.

---

# 4. OOP Features in Java

Java supports:

- Classes
- Objects
- Encapsulation
- Abstraction
- Inheritance
- Polymorphism
- Packages
- Interfaces

These features help build modular and reusable software.

---

# 5. Class and Object Example

```java
class Employee {

    private String name;

    Employee(String name) {
        this.name = name;
    }

    void work() {
        System.out.println(name + " is working.");
    }
}

public class Main {

    public static void main(String[] args) {

        Employee emp = new Employee("Alice");
        emp.work();
    }
}
```

---

# 6. Encapsulation

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

Data is hidden using `private` and accessed through public methods.

---

# 7. Inheritance

```java
class Vehicle {

    void start(){
        System.out.println("Vehicle Started");
    }
}

class Car extends Vehicle {

}
```

Inheritance promotes code reuse.

---

# 8. Polymorphism

```java
class Animal {

    void sound(){
        System.out.println("Animal");
    }
}

class Dog extends Animal {

    @Override
    void sound(){
        System.out.println("Bark");
    }
}

public class Main {

    public static void main(String[] args){

        Animal a = new Dog();
        a.sound();
    }
}
```

Output:

```text
Bark
```

The method executed depends on the actual object.

---

# 9. Abstraction

```java
interface Payment {

    void pay(double amount);
}

class UpiPayment implements Payment {

    public void pay(double amount){
        System.out.println("Paid via UPI");
    }
}
```

The interface specifies **what** should happen while implementations define **how**.

---

# 10. Why Java is Popular in Enterprises

Java powers:

- Banking Systems
- E-Commerce Platforms
- Telecom Applications
- ERP Systems
- Government Portals
- Healthcare Software

Frameworks like **Spring Boot**, **Hibernate**, and **Jakarta EE** rely heavily on OOP.

---

# 11. Is Java 100% Object-Oriented?

Not entirely.

Reasons:

- Primitive data types
- Static members
- Some low-level features

However, almost all enterprise Java applications are written using OOP principles.

---

# 12. Java vs C++

| Feature | Java | C++ |
|---------|------|-----|
| Memory Management | Automatic GC | Manual |
| Pointer Arithmetic | No | Yes |
| Multiple Inheritance (Classes) | No | Yes |
| Platform Independence | Yes (JVM) | No |
| Garbage Collection | Yes | No |

---

# 13. Advantages

- Platform independent
- Secure
- Robust
- Object-oriented
- Rich libraries
- Automatic memory management
- Excellent ecosystem

---

# Interview Questions

1. Why was Java developed?
2. How is Java different from C++?
3. Why is Java called platform independent?
4. Is Java 100% object-oriented?
5. Why is Java preferred for enterprise software?

---

# Summary

Java made Object-Oriented Programming practical, portable, and enterprise-friendly. By combining OOP with the JVM, automatic garbage collection, and a rich ecosystem, Java became one of the world's most widely used languages for building scalable business applications.
