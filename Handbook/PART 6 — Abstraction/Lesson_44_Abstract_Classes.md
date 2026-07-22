# Lesson 44 — Abstract Classes

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **abstract class** is a class that **cannot be instantiated**. It serves as a blueprint for other classes by providing common properties and behavior while allowing subclasses to implement specific functionality.

Abstract classes are useful when multiple related classes share common code but also require specialized behavior.

---

# 2. Why Use an Abstract Class?

Without an abstract class, duplicate code is often repeated across multiple classes.

With an abstract class:

- Common code is written once.
- Shared fields and methods are inherited.
- Subclasses implement only what is unique.

---

# 3. Declaring an Abstract Class

Use the `abstract` keyword.

```java
abstract class Animal {

    abstract void sound();
}
```

Since `Animal` is abstract, objects cannot be created directly.

```java
Animal a = new Animal(); // Compilation Error
```

---

# 4. Abstract Methods

An **abstract method** has no implementation.

```java
abstract class Shape {

    abstract double area();
}
```

Every concrete subclass must implement `area()`.

---

# 5. Concrete Methods

Abstract classes may also contain normal (concrete) methods.

```java
abstract class Animal {

    void sleep() {
        System.out.println("Sleeping...");
    }

    abstract void sound();
}
```

This allows common functionality to be shared.

---

# 6. Example

```java
abstract class Vehicle {

    abstract void start();

    void stop() {
        System.out.println("Vehicle Stopped");
    }
}

class Car extends Vehicle {

    @Override
    void start() {
        System.out.println("Car Started");
    }
}
```

Usage:

```java
Vehicle v = new Car();
v.start();
v.stop();
```

---

# 7. Constructor in an Abstract Class

Abstract classes can have constructors.

```java
abstract class Employee {

    Employee() {
        System.out.println("Employee Constructor");
    }
}
```

The constructor runs when a subclass object is created.

---

# 8. Abstract Class Hierarchy

```text
        Vehicle (Abstract)
              ▲
      ┌───────┴────────┐
      ▼                ▼
     Car            Motorcycle
```

The abstract class defines the common contract.

---

# 9. Enterprise Example

```java
abstract class Payment {

    abstract void pay(double amount);

    void printReceipt() {
        System.out.println("Receipt Generated");
    }
}

class CreditCardPayment extends Payment {

    @Override
    void pay(double amount) {
        System.out.println("Paid using Credit Card");
    }
}
```

Every payment type implements `pay()`, while receipt generation is shared.

---

# 10. Abstract Class vs Normal Class

| Normal Class | Abstract Class |
|--------------|----------------|
| Can create objects | Cannot create objects |
| May contain concrete methods | Can contain abstract and concrete methods |
| Used directly | Used as a base class |

---

# 11. Best Practices

- Use abstract classes for closely related classes.
- Place shared code in concrete methods.
- Declare only behavior that subclasses must implement as abstract.
- Avoid making every method abstract unnecessarily.

---

# 12. Common Mistakes

❌ Creating objects of an abstract class.

❌ Forgetting to implement abstract methods.

❌ Using an abstract class when there is no shared state or behavior.

---

# 13. Interview Questions

1. What is an abstract class?
2. Can we create an object of an abstract class?
3. Can an abstract class have constructors?
4. Can an abstract class contain concrete methods?
5. When should you use an abstract class?

---

# 14. Summary

An abstract class provides a common foundation for related classes by combining shared implementation with abstract methods that subclasses must implement. It reduces code duplication, promotes reuse, and supports polymorphism. In enterprise Java applications, abstract classes are commonly used when multiple classes share state and behavior but differ in specific implementations.
