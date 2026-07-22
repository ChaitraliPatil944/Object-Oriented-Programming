# Lesson 157 — Dependency Injection in Spring

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Dependency Injection (DI)** is a design pattern in which an object's dependencies are provided from the outside rather than created by the object itself.

Spring Framework has a built-in **Inversion of Control (IoC) Container** that automatically creates, manages, and injects objects (beans).

DI reduces coupling, improves testability, and follows the **Dependency Inversion Principle (DIP)**.

---

# 2. Why Dependency Injection?

Without DI:

- Classes create their own dependencies.
- Code becomes tightly coupled.
- Testing is difficult.
- Replacing implementations requires code changes.

With DI, classes depend on abstractions instead of concrete implementations.

---

# 3. Without Dependency Injection

```java
class EmailService {

    void send() {
        System.out.println("Sending email");
    }
}

class NotificationService {

    private EmailService emailService =
            new EmailService();

    void notifyUser() {
        emailService.send();
    }
}
```

`NotificationService` is tightly coupled to `EmailService`.

---

# 4. With Dependency Injection

```java
interface MessageService {
    void send();
}

class EmailService implements MessageService {

    public void send() {
        System.out.println("Sending email");
    }
}

class NotificationService {

    private final MessageService service;

    public NotificationService(MessageService service) {
        this.service = service;
    }

    void notifyUser() {
        service.send();
    }
}
```

Dependencies are supplied externally.

---

# 5. Spring IoC Container

```text
Application
      │
      ▼
Spring IoC Container
      │
Creates Beans
      │
Injects Dependencies
```

The container manages object lifecycle automatically.

---

# 6. Common Spring Annotations

| Annotation | Purpose |
|------------|---------|
| `@Component` | Generic Spring bean |
| `@Service` | Service layer bean |
| `@Repository` | Repository bean |
| `@Controller` | MVC controller |
| `@RestController` | REST controller |
| `@Autowired` | Inject dependency |

---

# 7. Constructor Injection

```java
@Service
public class UserService {

    private final UserRepository repository;

    public UserService(UserRepository repository) {
        this.repository = repository;
    }
}
```

Spring automatically injects the required repository.

---

# 8. Types of Dependency Injection

### Constructor Injection (Recommended)

```java
public UserService(UserRepository repository) {
    this.repository = repository;
}
```

### Setter Injection

```java
@Autowired
public void setRepository(UserRepository repository) {
    this.repository = repository;
}
```

### Field Injection

```java
@Autowired
private UserRepository repository;
```

Constructor injection is preferred because it supports immutability and easier testing.

---

# 9. Benefits

- Loose coupling
- Easier unit testing
- Better maintainability
- Flexible architecture
- Simple replacement of implementations

---

# 10. Best Practices

- Prefer constructor injection.
- Depend on interfaces.
- Keep beans focused.
- Avoid field injection in production code.
- Let Spring manage object creation.

---

# 11. Common Mistakes

❌ Creating dependencies with `new` inside Spring beans.

❌ Using field injection everywhere.

❌ Depending directly on concrete classes.

❌ Making beans responsible for unrelated tasks. One object trying to run the whole application is how software reenacts medieval kingdoms.

---

# 12. Interview Questions

1. What is Dependency Injection?
2. What is the IoC Container?
3. Constructor vs Setter vs Field Injection?
4. Why is constructor injection recommended?
5. How does DI relate to the Dependency Inversion Principle?

---

# 13. Quick Revision

```text
Dependency Injection
│
├── IoC Container
├── Beans
├── Constructor Injection
├── @Autowired
└── Loose Coupling
```

---

# 14. Interview Cheat Sheet

```text
Dependency Injection

✔ Dependencies Supplied Externally
✔ IoC Container
✔ Spring Beans

Annotations

@Component
@Service
@Repository
@RestController
@Autowired

Preferred

Constructor Injection
```

---

# 15. Summary

Dependency Injection is a core feature of Spring that allows objects to receive their dependencies from the IoC container instead of creating them directly. By combining interfaces, managed beans, and constructor injection, Spring applications become loosely coupled, highly testable, and easier to maintain, making DI a fundamental concept in enterprise Java development.
