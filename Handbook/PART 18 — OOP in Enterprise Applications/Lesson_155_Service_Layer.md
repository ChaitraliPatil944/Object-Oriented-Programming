# Lesson 155 — Service Layer

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Service Layer** is an architectural layer that contains the application's **business logic**.

It acts as an intermediary between the **Controller Layer** and the **Repository Layer**, ensuring that business rules remain separate from presentation and persistence logic.

In Spring Boot, service classes are typically annotated with `@Service`.

---

# 2. Why Use a Service Layer?

Without a service layer:

- Controllers become bloated with business logic.
- Database access may be scattered across the application.
- Testing and maintenance become difficult.

The service layer centralizes business operations.

---

# 3. Architecture

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

Each layer has a distinct responsibility.

---

# 4. Responsibilities

A service layer typically:

- Implements business rules
- Coordinates multiple repositories
- Validates business operations
- Manages transactions
- Calls external services when required

It should not handle HTTP requests or direct database operations.

---

# 5. Example Service

```java
@Service
public class UserService {

    private final UserRepository repository;

    public UserService(UserRepository repository) {
        this.repository = repository;
    }

    public User register(User user) {
        return repository.save(user);
    }
}
```

The service delegates persistence while applying business rules.

---

# 6. Calling the Service

```java
@RestController
public class UserController {

    private final UserService service;

    public UserController(UserService service) {
        this.service = service;
    }

    @PostMapping("/users")
    public User create(@RequestBody User user) {
        return service.register(user);
    }
}
```

The controller communicates only with the service.

---

# 7. Service Layer Flow

```text
HTTP Request
      │
      ▼
Controller
      │
      ▼
Service
      │
 ┌────┴────┐
 ▼         ▼
Repository External API
      │
      ▼
 Database
```

Services often coordinate multiple resources.

---

# 8. Benefits

- Separation of concerns
- Reusable business logic
- Easier unit testing
- Better maintainability
- Cleaner architecture

---

# 9. Best Practices

- Keep controllers thin.
- Place business rules in services.
- Inject dependencies through constructors.
- Use transactions where appropriate.
- Keep services cohesive and focused.

---

# 10. Common Mistakes

❌ Writing business logic in controllers.

❌ Accessing repositories directly from controllers.

❌ Mixing presentation logic with service logic.

❌ Creating overly large "God Services." Apparently giant classes reproduce just as enthusiastically as giant spreadsheets.

---

# 11. Service Layer vs Repository

| Service Layer | Repository |
|---------------|------------|
| Business logic | Data access |
| Coordinates operations | Performs CRUD |
| Calls repositories | Talks to database |

---

# 12. Interview Questions

1. What is the purpose of the service layer?
2. Why shouldn't controllers contain business logic?
3. What annotation marks a service in Spring?
4. Service layer vs repository?
5. Why is constructor injection preferred?

---

# 13. Quick Revision

```text
Service Layer
│
├── Business Logic
├── Validation
├── Transactions
├── Calls Repositories
└── Reusable Operations
```

---

# 14. Interview Cheat Sheet

```text
Service Layer

✔ Business Logic
✔ @Service
✔ Between Controller & Repository

Benefits

Maintainable
Reusable
Testable
Clean Architecture
```

---

# 15. Summary

The Service Layer is responsible for implementing an application's business logic while acting as the bridge between controllers and repositories. By centralizing business rules, coordinating operations, and keeping controllers and repositories focused on their respective responsibilities, the service layer promotes clean architecture, maintainability, and testability in enterprise Java applications.
