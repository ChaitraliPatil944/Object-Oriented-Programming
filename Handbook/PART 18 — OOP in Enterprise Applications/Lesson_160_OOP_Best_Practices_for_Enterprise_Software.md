# Lesson 160 — OOP Best Practices for Enterprise Software

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Writing object-oriented code is not just about using classes and objects. Enterprise software must also be maintainable, scalable, testable, and easy to extend.

Following proven OOP best practices helps teams build reliable applications that can evolve with changing business requirements.

---

# 2. Keep Classes Focused

Each class should have **one clear responsibility**.

```text
UserService
    ✔ User operations

EmailService
    ✔ Email operations
```

Avoid "God Classes" that perform many unrelated tasks.

---

# 3. Follow SOLID Principles

- **S**: Single Responsibility Principle
- **O**: Open/Closed Principle
- **L**: Liskov Substitution Principle
- **I**: Interface Segregation Principle
- **D**: Dependency Inversion Principle

These principles reduce coupling and improve maintainability.

---

# 4. Prefer Composition Over Inheritance

Instead of deep inheritance hierarchies:

```text
Car
 └── Engine
```

Prefer composing objects from smaller reusable components.

---

# 5. Program to Interfaces

```java
interface PaymentService {
    void pay();
}

class CreditCardPayment implements PaymentService { }
```

Depend on abstractions rather than concrete implementations.

---

# 6. Encapsulate Data

Keep fields private.

```java
private double balance;
```

Expose behavior through methods instead of allowing unrestricted access.

---

# 7. Keep Controllers Thin

```text
Controller
      │
Service
      │
Repository
```

Controllers should:

- Accept requests
- Validate input
- Call services
- Return responses

Business logic belongs in services.

---

# 8. Use DTOs

Never expose entities directly.

```text
Entity
   │
 Mapper
   │
DTO
```

DTOs improve security and API stability.

---

# 9. Constructor Injection

Preferred dependency injection style:

```java
public UserService(UserRepository repository) {
    this.repository = repository;
}
```

Benefits:

- Immutability
- Easier testing
- Clear dependencies

---

# 10. Write Reusable Methods

Bad:

```java
calculateSalaryForPermanentEmployee()
```

Better:

```java
calculateSalary(Employee employee)
```

Reusable methods reduce duplication.

---

# 11. Handle Exceptions Properly

- Catch only what you can handle.
- Use custom exceptions for business rules.
- Avoid empty catch blocks.

---

# 12. Keep Methods Small

Good methods:

- Perform one task
- Have descriptive names
- Remain easy to test and understand

If a method scrolls longer than your patience, it is probably asking to be split into smaller ones.

---

# 13. Write Unit Tests

Test:

- Business logic
- Edge cases
- Error handling

Benefits:

- Prevent regressions
- Increase confidence
- Simplify refactoring

---

# 14. Use Meaningful Names

Good:

```text
calculateTotal()
findCustomer()
processPayment()
```

Avoid vague names like:

```text
doTask()
temp()
data()
```

---

# 15. Layered Architecture

```text
Client
   │
Controller
   │
Service
   │
Repository
   │
Database
```

Each layer should communicate only with the layer directly below it.

---

# 16. Common Mistakes

❌ Large classes

❌ Duplicate code

❌ Tight coupling

❌ Deep inheritance

❌ Business logic inside controllers

❌ Returning entities directly

❌ Ignoring interfaces

---

# 17. Interview Questions

1. Why is encapsulation important?
2. Why is composition preferred over inheritance?
3. Why should controllers remain thin?
4. Why use constructor injection?
5. What are common enterprise OOP best practices?

---

# 18. Quick Revision

```text
Enterprise OOP

✔ SOLID
✔ DTO
✔ Repository
✔ Service Layer
✔ Constructor Injection
✔ Composition
✔ Encapsulation
✔ Unit Testing
```

---

# 19. Interview Cheat Sheet

```text
Best Practices

Single Responsibility
Composition
Interfaces
Encapsulation
DTOs
Dependency Injection
Small Methods
Layered Architecture
Meaningful Names
Testing
```

---

# 20. Summary

Enterprise-quality object-oriented software is built by combining sound OOP principles with clean architecture. By following SOLID, favoring composition, programming to interfaces, using layered architecture, constructor injection, DTOs, repositories, and thorough testing, developers create applications that are scalable, maintainable, secure, and easy to extend over time.
