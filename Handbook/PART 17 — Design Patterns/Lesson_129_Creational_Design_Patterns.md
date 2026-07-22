# Lesson 129 — Creational Design Patterns

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Creational Design Patterns focus on **how objects are created**.

Their goal is to make object creation:

- Flexible
- Reusable
- Decoupled
- Maintainable

Instead of directly creating objects everywhere with `new`, creational patterns centralize or simplify the creation process.

---

# 2. Why Creational Patterns?

Without them:

```text
Client
  │
new A()
new B()
new C()
```

Problems:

- Tight coupling
- Duplicate creation logic
- Difficult to extend

With creational patterns:

```text
Client
   │
Factory / Builder / Prototype
   │
Objects
```

---

# 3. Types of Creational Patterns

The Gang of Four defines five creational patterns:

| Pattern | Purpose |
|---------|---------|
| Singleton | Ensure only one instance exists |
| Factory | Delegate object creation |
| Abstract Factory | Create related object families |
| Builder | Construct complex objects step by step |
| Prototype | Create objects by cloning |

---

# 4. Singleton

Ensures exactly one instance of a class.

Typical uses:

- Logger
- Configuration manager
- Cache
- Thread pool

---

# 5. Factory

Creates objects without exposing the exact creation logic.

Example:

```text
Payment
 ├── CardPayment
 ├── UPIPayment
 └── WalletPayment
```

The client asks a factory for a payment implementation instead of calling constructors directly.

---

# 6. Abstract Factory

Creates **families of related objects**.

Example:

```text
GUI Factory

Windows
 ├── Button
 └── Checkbox

Mac
 ├── Button
 └── Checkbox
```

---

# 7. Builder

Useful for constructing complex objects with many optional fields.

Example:

```java
Student s = new StudentBuilder()
        .setName("Alice")
        .setAge(20)
        .setCity("Pune")
        .build();
```

---

# 8. Prototype

Creates new objects by cloning existing ones.

Useful when object creation is expensive.

```text
Existing Object
      │
    Clone
      │
 New Object
```

---

# 9. Choosing the Right Pattern

| Situation | Pattern |
|-----------|---------|
| One shared instance | Singleton |
| Hide creation logic | Factory |
| Related product families | Abstract Factory |
| Many optional parameters | Builder |
| Copy existing objects | Prototype |

---

# 10. Advantages

- Reduces coupling
- Improves flexibility
- Centralizes creation logic
- Supports Open/Closed Principle
- Simplifies maintenance

Because eventually someone asks for "just one more object type," and the code that hardcoded everything immediately files a complaint.

---

# 11. Interview Questions

1. What are creational design patterns?
2. Why use creational patterns?
3. Name the five GoF creational patterns.
4. Singleton vs Factory?
5. Builder vs Factory?
6. When is Prototype useful?

---

# 12. Quick Revision

```text
Creational Patterns

Singleton
Factory
Abstract Factory
Builder
Prototype

Purpose

Create Objects
Efficiently
Flexibly
Loosely Coupled
```

---

# 13. Summary

Creational design patterns provide structured approaches for object creation. By separating creation logic from business logic, they improve flexibility, reduce coupling, and make software easier to extend and maintain. The five GoF creational patterns are Singleton, Factory, Abstract Factory, Builder, and Prototype.
