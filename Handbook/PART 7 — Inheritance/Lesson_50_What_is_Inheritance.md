# Lesson 50 — What is Inheritance?

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Inheritance** is one of the four fundamental principles of Object-Oriented Programming (OOP).

Inheritance allows one class to **acquire the properties and behaviors of another class**. It promotes **code reusability**, **extensibility**, and supports **polymorphism**.

---

# 2. Definition

Inheritance is a mechanism where a **child class (subclass)** inherits fields and methods from a **parent class (superclass)**.

```text
Parent Class
     ▲
     │
extends
     │
Child Class
```

The child class can reuse existing functionality and add its own features.

---

# 3. Why Use Inheritance?

Without inheritance:

- Common code is duplicated.
- Maintenance becomes difficult.
- Changes must be repeated in multiple classes.

With inheritance:

- Code reuse increases.
- Maintenance becomes easier.
- Applications become more extensible.

---

# 4. Syntax

Java uses the `extends` keyword.

```java
class Animal {

    void eat() {
        System.out.println("Eating...");
    }
}

class Dog extends Animal {

    void bark() {
        System.out.println("Barking...");
    }
}
```

Usage:

```java
Dog dog = new Dog();

dog.eat();
dog.bark();
```

The `Dog` class inherits the `eat()` method from `Animal`.

---

# 5. Parent and Child Classes

```text
        Animal
           ▲
           │
        extends
           │
          Dog
```

- **Superclass (Parent):** Animal
- **Subclass (Child):** Dog

---

# 6. What Can Be Inherited?

A subclass inherits:

- Public methods
- Protected methods
- Public fields
- Protected fields

It does **not** inherit:

- Private members (directly)
- Constructors

---

# 7. Example: Employee Hierarchy

```java
class Employee {

    void work() {
        System.out.println("Working...");
    }
}

class Manager extends Employee {

    void approveLeave() {
        System.out.println("Leave Approved");
    }
}
```

The `Manager` class automatically gets the `work()` method.

---

# 8. Advantages of Inheritance

- Code reuse
- Easier maintenance
- Better organization
- Supports polymorphism
- Faster development
- Extensible design

---

# 9. Enterprise Example

```java
class User {

    String username;

    void login() {
        System.out.println("User Logged In");
    }
}

class Admin extends User {

    void manageUsers() {
        System.out.println("Managing Users");
    }
}
```

The `Admin` class reuses authentication behavior while adding administrator-specific functionality.

---

# 10. UML Representation

```text
        +-----------+
        |  Animal   |
        +-----------+
        | + eat()   |
        +-----------+
              ▲
              │
        +-----------+
        |    Dog    |
        +-----------+
        | + bark()  |
        +-----------+
```

---

# 11. Common Mistakes

❌ Using inheritance only to reuse code.

❌ Creating inheritance between unrelated classes.

❌ Forgetting that constructors are not inherited.

❌ Violating the "is-a" relationship.

---

# 12. Best Practices

- Use inheritance only when an "is-a" relationship exists.
- Keep inheritance hierarchies simple.
- Prefer composition when inheritance is not natural.
- Override methods carefully.
- Avoid deep inheritance trees.

---

# 13. Interview Questions

1. What is inheritance?
2. Why is inheritance important?
3. Which keyword is used for inheritance in Java?
4. What members are inherited?
5. Are constructors inherited?
6. What are the advantages of inheritance?

---

# 14. Summary

Inheritance enables one class to acquire the properties and behaviors of another class, reducing code duplication and promoting reuse. It forms the foundation for polymorphism and helps organize related classes into logical hierarchies. In enterprise Java applications, inheritance is used to build extensible and maintainable object-oriented systems while following the "is-a" relationship.
