# Lesson 174 — OOP Cheatsheet

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. OOP Pillars

```text
Encapsulation
↓
Hide data using private fields

Abstraction
↓
Show only essential features

Inheritance
↓
Reuse existing code

Polymorphism
↓
One interface, many implementations
```

---

# 2. Class vs Object

| Class | Object |
|-------|--------|
| Blueprint | Instance |
| Logical entity | Physical entity |
| No memory until instantiated | Occupies memory |

---

# 3. Encapsulation

```java
class Account {
    private double balance;

    public void deposit(double amount){
        balance += amount;
    }
}
```

✔ Hide data
✔ Controlled access

---

# 4. Inheritance

```text
Animal
   │
 ├── Dog
 └── Cat
```

Relationship:

```text
IS-A
```

---

# 5. Polymorphism

Compile-time

```java
add(int,int)
add(double,double)
```

Runtime

```java
Animal a = new Dog();
a.sound();
```

---

# 6. Abstraction

```java
abstract class Shape {
    abstract void draw();
}
```

or

```java
interface Payment {
    void pay();
}
```

---

# 7. Overloading vs Overriding

| Overloading | Overriding |
|-------------|------------|
| Same method name | Same method signature |
| Different parameters | Different implementation |
| Compile time | Runtime |

---

# 8. Abstract Class vs Interface

| Abstract Class | Interface |
|----------------|-----------|
| Constructors | No constructors |
| State allowed | Constants only |
| Partial implementation | Contract |
| extends | implements |

---

# 9. Relationships

```text
Association

A ---- B

Aggregation

Car <> Engine

Composition

House ◆ Room

Inheritance

Vehicle
   │
 Car
```

---

# 10. SOLID

```text
S → Single Responsibility

O → Open/Closed

L → Liskov Substitution

I → Interface Segregation

D → Dependency Inversion
```

---

# 11. Common Design Patterns

| Pattern | Purpose |
|---------|---------|
| Singleton | One instance |
| Factory | Object creation |
| Builder | Complex object construction |
| Strategy | Select algorithm |
| Observer | Event notification |
| Adapter | Convert interfaces |
| Facade | Simplify subsystem |

---

# 12. Enterprise Layers

```text
Controller
    │
Service
    │
Repository
    │
Database
```

---

# 13. JVM Essentials

```text
.java
   │
Compiler
   │
.class
   │
JVM
   │
Machine Code
```

---

# 14. Performance Tips

✔ Use efficient algorithms

✔ Choose correct collections

✔ Use StringBuilder for repeated concatenation

✔ Minimize unnecessary object creation

✔ Profile before optimizing

---

# 15. Interview Formula

```text
Requirements
      │
Entities
      │
Relationships
      │
Responsibilities
      │
SOLID
      │
Patterns
      │
Layers
```

---

# 16. One-Page Revision

```text
OOP

Class
Object
Encapsulation
Abstraction
Inheritance
Polymorphism

Design

SOLID
Composition
Interfaces
Patterns

Enterprise

Controller
Service
Repository
DTO

JVM

Bytecode
Class Loader
Reflection
Annotations
JIT

Performance

Algorithms
Collections
StringBuilder
Profiling
```

---

# 17. Summary

This cheatsheet condenses the most important OOP concepts, Java architecture topics, design principles, design patterns, enterprise practices, and interview facts into a quick-reference guide for rapid revision before exams and technical interviews.
