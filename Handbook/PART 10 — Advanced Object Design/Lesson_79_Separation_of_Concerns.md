# Lesson 79 — Separation of Concerns (SoC)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Separation of Concerns (SoC)** is a software design principle that divides an application into distinct sections, where each section addresses a single concern or responsibility.

A **concern** is a specific feature, responsibility, or functionality of a software system.

By separating concerns, applications become easier to develop, understand, test, maintain, and scale.

---

# 2. Definition

Separation of Concerns means:

> Each module, class, or layer should focus on one responsibility and avoid handling unrelated responsibilities.

```text
Application
│
├── Presentation
├── Business Logic
├── Data Access
└── Database
```

Each layer handles only its own concern.

---

# 3. Why SoC?

Without SoC:

- Large, complex classes
- Mixed UI and business logic
- Difficult debugging
- Poor maintainability

With SoC:

- Clear responsibilities
- Easier testing
- Better modularity
- Easier scalability

---

# 4. Java Example

```java
class UserRepository {

    void saveUser() {
        System.out.println("Saving user...");
    }
}

class UserService {

    private UserRepository repository = new UserRepository();

    void registerUser() {
        repository.saveUser();
    }
}

class UserController {

    private UserService service = new UserService();

    void register() {
        service.registerUser();
    }
}
```

Responsibilities:

- Controller → Handles requests
- Service → Business logic
- Repository → Database operations

---

# 5. Enterprise Layered Example

```text
Client
   │
   ▼
Controller
   │
   ▼
Service
   │
   ▼
Repository
   │
   ▼
Database
```

Each layer communicates only with the appropriate adjacent layer.

---

# 6. Relationship with Other Principles

| Principle | Purpose |
|-----------|---------|
| SRP | One responsibility per class |
| SoC | One concern per module/layer |
| Modularity | Divide application into modules |
| Low Coupling | Reduce dependencies |
| High Cohesion | Keep related responsibilities together |

---

# 7. Advantages

- Better maintainability
- Improved readability
- Easier debugging
- Independent testing
- Better scalability
- Easier teamwork

---

# 8. Best Practices

- Separate UI, business logic, and data access.
- Follow layered architecture.
- Keep modules cohesive.
- Avoid mixing responsibilities.

---

# 9. Common Mistakes

❌ Mixing database code inside UI classes.

❌ Writing business logic in controllers.

❌ One class handling multiple concerns.

---

# 10. Interview Questions

1. What is Separation of Concerns?
2. Why is SoC important?
3. Difference between SoC and SRP?
4. How does layered architecture support SoC?
5. Give enterprise examples.

---

# 11. Quick Revision

```text
Separation of Concerns
│
├── UI Layer
├── Business Layer
├── Data Layer
├── Independent Responsibilities
└── Better Maintainability
```

---

# 12. Interview Cheat Sheet

```text
SoC
│
├── Separate Responsibilities
├── Layered Design
├── Better Testing
├── Easier Maintenance
└── Improved Scalability
```

---

# 13. Summary

Separation of Concerns is a fundamental software design principle that divides an application into independent responsibilities. By separating presentation, business logic, and data access, applications become easier to understand, test, extend, and maintain. Modern enterprise frameworks such as Spring Boot, ASP.NET, and Django strongly follow this principle through layered architectures.
