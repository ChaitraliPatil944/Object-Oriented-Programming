# Lesson 81 — Inversion of Control (IoC)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Inversion of Control (IoC)** is a software design principle in which the control of creating and managing objects is transferred from the application code to an external framework or container.

IoC is the foundation of enterprise frameworks such as:

- Spring Framework
- Spring Boot
- Jakarta EE
- ASP.NET Core

Dependency Injection (DI) is the most common way to implement IoC.

---

# 2. What is Inversion of Control?

Traditionally, classes create and manage their own dependencies.

With IoC, an external container creates the objects and provides them when required.

```text
Without IoC

Application
    │
creates objects
    ▼
Dependencies

-------------------------

With IoC

IoC Container
      │
creates & manages
      ▼
Dependencies
      │
injects
      ▼
Application
```

---

# 3. Why IoC?

Without IoC

- Tight coupling
- Difficult testing
- Manual object creation
- Poor maintainability

With IoC

- Loose coupling
- Centralized object management
- Easy testing
- Better scalability

---

# 4. Java Example (Without IoC)

```java
class Engine {
    void start() {
        System.out.println("Engine Started");
    }
}

class Car {

    private Engine engine = new Engine();

    void drive() {
        engine.start();
    }
}
```

The `Car` class controls object creation.

---

# 5. Java Example (With IoC + DI)

```java
interface Engine {
    void start();
}

class PetrolEngine implements Engine {

    public void start() {
        System.out.println("Petrol Engine Started");
    }
}

class Car {

    private Engine engine;

    Car(Engine engine) {
        this.engine = engine;
    }

    void drive() {
        engine.start();
    }
}
```

The object is supplied externally.

---

# 6. IoC Container

An IoC Container is responsible for:

- Creating objects
- Managing object lifecycle
- Injecting dependencies
- Destroying objects when required

Example:

```text
Spring IoC Container
        │
        ├── Creates Beans
        ├── Manages Beans
        └── Injects Beans
```

---

# 7. IoC vs Dependency Injection

| IoC | DI |
|-----|----|
| Design Principle | Design Pattern |
| Transfers control | Implements IoC |
| Broad concept | Practical implementation |
| Achieved using DI | One way to achieve IoC |

---

# 8. Enterprise Example

```text
Controller
      │
      ▼
Service
      │
      ▼
Repository
```

The Spring IoC Container creates these objects and injects them automatically.

---

# 9. Advantages

- Loose coupling
- Centralized configuration
- Better maintainability
- Easier testing
- Reusable components
- Scalable architecture

---

# 10. Best Practices

- Depend on interfaces.
- Prefer Constructor Injection.
- Keep objects stateless where possible.
- Let the IoC container manage object creation.

---

# 11. Common Mistakes

❌ Confusing IoC with Dependency Injection.

❌ Creating dependencies manually despite using an IoC container.

❌ Overusing global/static objects.

---

# 12. Interview Questions

1. What is Inversion of Control?
2. How is IoC different from DI?
3. What is an IoC Container?
4. Why do enterprise frameworks use IoC?
5. How does Spring implement IoC?

---

# 13. Quick Revision

```text
IoC
│
├── Design Principle
├── Container manages objects
├── DI implements IoC
├── Loose Coupling
└── Enterprise Frameworks
```

---

# 14. Interview Cheat Sheet

```text
Without IoC
Application ──creates──► Objects ❌

With IoC
Container ──creates──► Objects
          │
          └──injects──► Application ✅
```

---

# 15. Summary

Inversion of Control is a design principle that shifts the responsibility of object creation and lifecycle management from application code to an external container. Dependency Injection is the most common technique used to implement IoC. Together, they reduce coupling, improve maintainability, simplify testing, and form the backbone of modern enterprise Java development.
