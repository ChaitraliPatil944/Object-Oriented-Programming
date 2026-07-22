# Lesson 45 — Interfaces

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **interface** in Java is a reference type that defines a **contract** for classes. It specifies **what a class must do**, but not **how it should do it**.

Interfaces are widely used to achieve abstraction, loose coupling, and multiple inheritance of type.

---

# 2. Why Use Interfaces?

Interfaces help:

- Define a common contract
- Achieve abstraction
- Support multiple inheritance
- Reduce coupling
- Improve flexibility and extensibility

Instead of depending on concrete classes, applications depend on interfaces.

---

# 3. Declaring an Interface

Use the `interface` keyword.

```java
interface Animal {

    void sound();
}
```

Methods are implicitly:

- `public`
- `abstract`

---

# 4. Implementing an Interface

A class uses the `implements` keyword.

```java
interface Animal {
    void sound();
}

class Dog implements Animal {

    @Override
    public void sound() {
        System.out.println("Bark");
    }
}
```

The implementing class must provide the method implementation.

---

# 5. Creating Objects

Interfaces cannot be instantiated.

```java
Animal a = new Dog();
a.sound();
```

Here, the reference type is the interface, while the object belongs to the implementing class.

---

# 6. Multiple Interface Implementation

A class can implement multiple interfaces.

```java
interface Flyable {
    void fly();
}

interface Swimmable {
    void swim();
}

class Duck implements Flyable, Swimmable {

    public void fly() {
        System.out.println("Flying");
    }

    public void swim() {
        System.out.println("Swimming");
    }
}
```

This is one of Java's ways of supporting multiple inheritance.

---

# 7. Default and Static Methods

Since Java 8, interfaces can contain default and static methods.

```java
interface Printer {

    default void start() {
        System.out.println("Printer Ready");
    }

    static void info() {
        System.out.println("Printer Interface");
    }
}
```

Default methods provide reusable implementations without breaking existing classes.

---

# 8. Functional Interfaces

A functional interface contains exactly one abstract method.

Example:

```java
@FunctionalInterface
interface Calculator {

    int add(int a, int b);
}
```

Functional interfaces are used with lambda expressions.

---

# 9. Interface Hierarchy

```text
           Animal (Interface)
                 ▲
          implements
                 ▲
               Dog
```

The interface defines the contract.

The class provides the implementation.

---

# 10. Enterprise Example

```java
interface Payment {

    void pay(double amount);
}

class CreditCardPayment implements Payment {

    public void pay(double amount) {
        System.out.println("Paid using Credit Card");
    }
}

class UPIPayment implements Payment {

    public void pay(double amount) {
        System.out.println("Paid using UPI");
    }
}
```

The application works with the `Payment` interface, allowing payment methods to be changed without modifying client code.

---

# 11. Interface vs Abstract Class

| Interface | Abstract Class |
|------------|----------------|
| Defines a contract | Defines a partial implementation |
| Supports multiple inheritance | Supports single inheritance |
| No instance variables (except constants) | Can have instance variables |
| Implemented using `implements` | Extended using `extends` |

---

# 12. Best Practices

- Program to interfaces, not implementations.
- Keep interfaces focused and cohesive.
- Use interfaces to define capabilities.
- Avoid creating overly large interfaces.

---

# 13. Common Mistakes

❌ Trying to instantiate an interface.

❌ Forgetting to implement all abstract methods.

❌ Using interfaces when shared implementation is required.

---

# 14. Interview Questions

1. What is an interface?
2. Why are interfaces used?
3. Can an interface have constructors?
4. Can a class implement multiple interfaces?
5. What are default methods?
6. What is a functional interface?
7. What is the difference between an interface and an abstract class?

---

# 15. Summary

Interfaces define contracts that classes agree to implement. They promote abstraction, loose coupling, and flexibility by separating behavior from implementation. Java interfaces support multiple inheritance of type and are extensively used in enterprise frameworks, APIs, dependency injection, and design patterns to build scalable and maintainable software.
