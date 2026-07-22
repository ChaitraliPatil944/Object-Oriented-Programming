# Lesson 132 — Abstract Factory Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Abstract Factory Pattern** is a creational design pattern that provides an interface for creating **families of related objects** without specifying their concrete classes.

Unlike the Factory pattern, which creates one type of object, Abstract Factory creates multiple related objects together.

---

# 2. Problem

Suppose an application supports multiple operating systems.

Each OS needs matching UI components.

```text
Windows

Button
Checkbox

Mac

Button
Checkbox
```

Creating each object manually scatters platform-specific logic.

---

# 3. Solution

```text
Client
   │
GUI Factory
   │
 ├── Windows Factory
 └── Mac Factory
        │
Creates Related Objects
```

The client works only with abstract interfaces.

---

# 4. Participants

- Abstract Factory
- Concrete Factories
- Abstract Products
- Concrete Products
- Client

---

# 5. Example Structure

```text
GUIFactory
   │
 ├── WindowsFactory
 └── MacFactory

Button
 ├── WindowsButton
 └── MacButton

Checkbox
 ├── WindowsCheckbox
 └── MacCheckbox
```

---

# 6. Abstract Products

```java
interface Button {
    void paint();
}

interface Checkbox {
    void check();
}
```

---

# 7. Abstract Factory

```java
interface GUIFactory {

    Button createButton();

    Checkbox createCheckbox();
}
```

---

# 8. Concrete Factory

```java
class WindowsFactory implements GUIFactory {

    public Button createButton() {
        return new WindowsButton();
    }

    public Checkbox createCheckbox() {
        return new WindowsCheckbox();
    }
}
```

A `MacFactory` would return the macOS versions.

---

# 9. Client

```java
GUIFactory factory = new WindowsFactory();

Button button = factory.createButton();
Checkbox checkbox = factory.createCheckbox();
```

The client never depends on concrete product classes.

---

# 10. How It Works

```text
Client
   │
Abstract Factory
   │
Concrete Factory
   │
Related Objects
```

Switching factories changes the entire product family.

---

# 11. Advantages

- Consistent product families
- Loose coupling
- Easy to swap implementations
- Supports Open/Closed Principle
- Centralized object creation

---

# 12. Disadvantages

- More interfaces and classes
- Higher initial complexity
- Adding a new product type requires updating all factories

Because software architects occasionally decide that one factory simply wasn't ambitious enough.

---

# 13. Factory vs Abstract Factory

| Factory | Abstract Factory |
|---------|------------------|
| Creates one product | Creates related product families |
| Simpler | More flexible |
| One factory method | Multiple factory methods |

---

# 14. Real-World Uses

- Cross-platform GUI toolkits
- Database driver families
- Theme engines
- Cloud provider SDKs
- Enterprise application frameworks

---

# 15. Interview Questions

1. What is the Abstract Factory pattern?
2. Factory vs Abstract Factory?
3. When should you use Abstract Factory?
4. What problem does it solve?
5. What are its advantages and disadvantages?

---

# 16. Quick Revision

```text
Abstract Factory

✔ Creates Families
✔ Related Objects
✔ Loose Coupling
✔ Product Consistency

Flow

Client
   │
Abstract Factory
   │
Concrete Factory
   │
Concrete Products
```

---

# 17. Summary

The Abstract Factory pattern creates families of related objects while hiding their concrete implementations from clients. It promotes consistency, loose coupling, and extensibility, making it an excellent choice for applications that must support multiple platforms, themes, or interchangeable product families.
