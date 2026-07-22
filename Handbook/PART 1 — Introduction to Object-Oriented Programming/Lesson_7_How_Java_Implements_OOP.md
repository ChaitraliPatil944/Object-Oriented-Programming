# Lesson 7 — How Java Implements OOP

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Java is one of the most widely used Object-Oriented Programming (OOP) languages. It was designed with the philosophy of "Write Once, Run Anywhere (WORA)" and provides strong support for OOP concepts through classes, objects, inheritance, polymorphism, abstraction, and encapsulation.

Unlike procedural languages that organize programs around functions, Java organizes software around objects.

---

# 2. Why Java is Called an Object-Oriented Language

Java models software using:

- Classes
- Objects
- Methods
- Constructors
- Packages
- Interfaces

Example:

```java
class Student {

    private String name;

    public Student(String name) {
        this.name = name;
    }

    public void study() {
        System.out.println(name + " is studying.");
    }
}

public class Main {

    public static void main(String[] args) {

        Student s = new Student("Alice");
        s.study();
    }
}
```

---

# 3. Java OOP Architecture

```text
                Java Program
                     │
                     ▼
                  Class
                     │
        +------------+------------+
        |                         |
        ▼                         ▼
   Fields (State)          Methods (Behavior)
        │                         │
        +------------+------------+
                     │
                     ▼
                  Object
```

---

# 4. Everything Starts with a Class

A class is a blueprint.

```java
class Car {

    String brand;
    int speed;

    void start() {
        System.out.println("Car Started");
    }
}
```

---

# 5. Creating Objects

```java
Car car = new Car();
car.brand = "BMW";
car.speed = 120;
car.start();
```

### What Happens Internally?

```text
new Car()

      │
      ▼
JVM allocates memory on Heap

      │
      ▼
Constructor executes

      │
      ▼
Reference stored in Stack
```

---

# 6. Encapsulation in Java

```java
class BankAccount {

    private double balance;

    public void deposit(double amount) {
        balance += amount;
    }

    public double getBalance() {
        return balance;
    }
}
```

The `private` keyword hides data and public methods provide controlled access.

---

# 7. Abstraction in Java

Using an interface:

```java
interface Payment {

    void pay(double amount);
}

class CreditCardPayment implements Payment {

    public void pay(double amount) {
        System.out.println("Paid: " + amount);
    }
}
```

The caller knows *what* to do (`pay`) without worrying about *how* it is implemented.

---

# 8. Inheritance in Java

```java
class Vehicle {

    void start() {
        System.out.println("Vehicle Started");
    }
}

class Car extends Vehicle {

}
```

`Car` automatically inherits the `start()` method.

---

# 9. Polymorphism in Java

```java
class Animal {

    void sound() {
        System.out.println("Animal Sound");
    }
}

class Dog extends Animal {

    @Override
    void sound() {
        System.out.println("Bark");
    }
}

public class Main {

    public static void main(String[] args) {

        Animal a = new Dog();
        a.sound();
    }
}
```

Output:

```text
Bark
```

This is runtime polymorphism.

---

# 10. Packages

Packages organize related classes.

```text
com.company.bank

├── Customer.java
├── Account.java
├── Transaction.java
└── Loan.java
```

Packages improve modularity and maintainability.

---

# 11. Java and Enterprise Applications

Java powers:

- Banking Systems
- E-Commerce
- ERP
- Telecom
- Healthcare
- Government Portals

Frameworks such as Spring Boot and Hibernate are built on OOP principles.

---

# 12. Is Java 100% Object-Oriented?

Not completely.

Reasons:

- Primitive data types (`int`, `double`, `char`, etc.)
- Static methods
- Static variables

However, Java is considered a strongly object-oriented language because almost all enterprise code is written using objects.

---

# 13. Advantages of Java's OOP Model

- Code Reusability
- Platform Independence
- Maintainability
- Scalability
- Security
- Automatic Garbage Collection

---

# 14. Interview Questions

1. Why is Java considered object-oriented?
2. Is Java 100% object-oriented? Why or why not?
3. How does Java implement encapsulation?
4. What happens internally when `new` is used?
5. How do packages support OOP?

---

# Summary

Java implements OOP by organizing software around classes and objects while providing language features such as encapsulation, abstraction, inheritance, and polymorphism. Combined with packages, automatic memory management, and the JVM, Java enables developers to build secure, modular, and scalable enterprise applications.
