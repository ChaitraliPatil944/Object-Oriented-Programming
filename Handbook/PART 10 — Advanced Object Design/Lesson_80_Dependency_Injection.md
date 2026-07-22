# Lesson 80 — Dependency Injection (DI)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Dependency Injection (DI)** is a software design pattern used to achieve **Loose Coupling** between classes.

Instead of a class creating its own dependent objects using `new`, the required objects are **provided (injected)** from outside.

Dependency Injection is one of the most important concepts in enterprise Java development and is heavily used in frameworks such as **Spring**, **Spring Boot**, **Jakarta EE**, and **ASP.NET Core**.

---

# 2. What is Dependency Injection?

Dependency Injection means:

> A class receives the objects it depends on instead of creating them itself.

Without DI:

```text
Car
 │
 └── creates Engine
```

With DI:

```text
Engine
   │
Injected
   ▼
Car
```

---

# 3. Why Dependency Injection?

Without DI:

- Tight coupling
- Difficult testing
- Hard to replace implementations
- Poor maintainability

With DI:

- Loose coupling
- Easy unit testing
- Better flexibility
- Easier maintenance

---

# 4. Java Example (Without DI)

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

Problem:

- Car always uses Engine.
- Cannot replace Engine easily.

---

# 5. Java Example (With Constructor Injection)

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

Engine engine = new PetrolEngine();
Car car = new Car(engine);

car.drive();
```

---

# 6. Types of Dependency Injection

## Constructor Injection (Recommended)

```java
Car(Engine engine)
```

Advantages:

- Mandatory dependencies
- Immutable objects
- Easy testing

---

## Setter Injection

```java
void setEngine(Engine engine)
```

Advantages:

- Optional dependencies
- Can replace dependency later

---

## Field Injection

```java
@Autowired
private Engine engine;
```

Common in Spring but generally less preferred because it makes testing harder.

---

# 7. Enterprise Example

```text
Controller
      │
      ▼
Service
      │
      ▼
Repository
```

Spring automatically injects dependencies between layers.

---

# 8. Advantages

- Loose coupling
- Better maintainability
- Easier unit testing
- Easy implementation replacement
- Better scalability
- Supports SOLID principles

---

# 9. Best Practices

- Prefer Constructor Injection.
- Depend on interfaces.
- Avoid creating dependencies with `new`.
- Keep dependencies explicit.

---

# 10. Common Mistakes

❌ Using Field Injection everywhere.

❌ Injecting too many dependencies.

❌ Depending directly on concrete classes.

---

# 11. Interview Questions

1. What is Dependency Injection?
2. Why is DI important?
3. Types of Dependency Injection?
4. Why is Constructor Injection preferred?
5. How does Spring implement DI?

---

# 12. Quick Revision

```text
Dependency Injection
│
├── Constructor Injection ⭐
├── Setter Injection
├── Field Injection
├── Loose Coupling
└── Better Testing
```

---

# 13. Interview Cheat Sheet

```text
Dependency Injection

Without DI
Class ──creates──► Object ❌

With DI
Object ──injected──► Class ✅
```

---

# 14. Summary

Dependency Injection is a design pattern that allows classes to receive their dependencies from external sources instead of creating them internally. It reduces coupling, improves maintainability, simplifies testing, and enables flexible software architectures. Constructor Injection is the preferred approach in modern enterprise Java applications because it produces immutable, testable, and well-defined dependencies.
