# Lesson 127 — SOLID in Real Projects

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **SOLID principles** are not just interview concepts. They are widely used in enterprise applications to create software that is maintainable, scalable, testable, and easy to extend.

Frameworks such as **Spring Boot**, **Hibernate**, and many large-scale Java applications are built around these principles.

---

# 2. Recap of SOLID

| Principle | Purpose |
|-----------|---------|
| **S** - Single Responsibility | One responsibility per class |
| **O** - Open Closed | Extend without modifying existing code |
| **L** - Liskov Substitution | Subclasses should replace parent classes safely |
| **I** - Interface Segregation | Small, client-specific interfaces |
| **D** - Dependency Inversion | Depend on abstractions, not implementations |

---

# 3. SOLID in an E-Commerce Application

```text
Customer
    │
    ▼
Order Service
    │
    ├── Payment Service
    ├── Inventory Service
    ├── Shipping Service
    └── Notification Service
```

Each service has a single responsibility and communicates through interfaces.

---

# 4. Applying SRP

Instead of one huge class:

```java
class OrderManager {

    void placeOrder() {}
    void processPayment() {}
    void sendEmail() {}
    void updateInventory() {}
}
```

Split responsibilities:

```text
OrderService
PaymentService
InventoryService
NotificationService
```

Each class has one reason to change.

---

# 5. Applying OCP

```java
interface PaymentMethod {
    void pay();
}

class CreditCardPayment implements PaymentMethod {
    public void pay() {}
}

class UpiPayment implements PaymentMethod {
    public void pay() {}
}
```

Adding PayPal requires only a new implementation, not modifying existing code.

---

# 6. Applying LSP

```text
Vehicle
   ▲
 ┌─┴───────┐
Car      Bike
```

Any code expecting a `Vehicle` should work correctly with `Car` or `Bike` without special handling.

---

# 7. Applying ISP

```java
interface Printer {
    void print();
}

interface Scanner {
    void scan();
}
```

Devices implement only the interfaces they actually support.

---

# 8. Applying DIP

```java
interface Database {
    void save();
}

class MySQLDatabase implements Database {
    public void save() {}
}

class UserService {

    private final Database database;

    UserService(Database database) {
        this.database = database;
    }
}
```

`UserService` depends on the `Database` abstraction instead of a concrete database implementation.

---

# 9. SOLID in Spring Boot

Spring Boot naturally supports SOLID through:

- Dependency Injection
- Interfaces
- Service layer separation
- Repository pattern
- Controller-Service-Repository architecture

---

# 10. Benefits in Real Projects

- Easier maintenance
- Better testing with mocks
- Lower coupling
- Higher cohesion
- Faster feature development
- Better scalability
- Cleaner architecture

---

# 11. Common Mistakes

❌ Creating "God Classes."

❌ Using inheritance where composition is better.

❌ Tight coupling to concrete classes.

❌ Large interfaces with unrelated methods.

❌ Ignoring abstractions to save a few lines of code. Humans love creating future problems to save present effort.

---

# 12. Best Practices

- Keep classes small and focused.
- Program to interfaces.
- Prefer composition over inheritance when appropriate.
- Inject dependencies rather than creating them.
- Refactor regularly as requirements evolve.

---

# 13. Interview Questions

1. Why are SOLID principles important in enterprise applications?
2. Which SOLID principle is most commonly implemented using Dependency Injection?
3. How does Spring Boot support SOLID?
4. Give a real-world example of each SOLID principle.
5. Can a project violate one SOLID principle but still function?

---

# 14. Quick Revision

```text
SOLID
│
├── SRP → One Responsibility
├── OCP → Extend, Don't Modify
├── LSP → Safe Substitution
├── ISP → Small Interfaces
└── DIP → Depend on Abstractions
```

---

# 15. Interview Cheat Sheet

```text
SOLID in Real Projects

SRP → Separate Services
OCP → Add Features via Interfaces
LSP → Reliable Inheritance
ISP → Focused Interfaces
DIP → Dependency Injection

Benefits

✔ Maintainable
✔ Testable
✔ Scalable
✔ Flexible
✔ Enterprise Ready
```

---

# 16. Summary

SOLID principles provide the foundation for designing clean, maintainable, and scalable object-oriented software. In real-world Java projects, they guide developers toward loosely coupled, highly cohesive architectures by emphasizing focused classes, extensible designs, safe inheritance, small interfaces, and dependency on abstractions. Modern frameworks like Spring Boot embrace these principles extensively, making SOLID essential knowledge for professional software development.
