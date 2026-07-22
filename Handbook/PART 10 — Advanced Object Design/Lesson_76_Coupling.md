# Lesson 76 — Coupling

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Coupling** measures the degree of dependency between classes or modules.

- **Low Coupling** → Preferred
- **High Coupling** → Avoid whenever possible

Low coupling makes software easier to modify, test, and maintain.

---

# 2. Definition

Coupling is the level of interdependence between software components.

```text
Class A  ------->  Class B
        Dependency
```

The more one class depends on another, the higher the coupling.

---

# 3. Types of Coupling

## Tight Coupling

One class directly creates or controls another.

```java
class Car {
    private Engine engine = new Engine();
}
```

Changes in `Engine` can directly affect `Car`.

## Loose Coupling

One class depends on an abstraction.

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

---

# 4. Real-World Example

```text
Remote Control
      │
      ▼
Television

Remote works with any compatible TV.
```

The remote depends on an interface, not one specific television implementation.

---

# 5. Enterprise Example

```text
Controller
    │
    ▼
Service Interface
    │
    ▼
Service Implementation
```

Business logic depends on interfaces, allowing implementations to change without affecting clients.

---

# 6. Advantages of Low Coupling

- Easier maintenance
- Better scalability
- Easier unit testing
- Improved flexibility
- Higher code reuse

---

# 7. Best Practices

- Program to interfaces.
- Use Dependency Injection.
- Follow SOLID principles.
- Avoid hard-coded object creation.

---

# 8. Common Mistakes

❌ Directly depending on concrete classes.

❌ Creating unnecessary dependencies.

❌ Violating the Dependency Inversion Principle.

---

# 9. Interview Questions

1. What is coupling?
2. Difference between tight and loose coupling?
3. Why is low coupling preferred?
4. How does Dependency Injection reduce coupling?
5. Give enterprise examples.

---

# 10. Quick Revision

```text
Coupling
│
├── Tight Coupling ❌
│   ├── Direct dependency
│   └── Hard to modify
│
└── Loose Coupling ✅
    ├── Interfaces
    ├── Flexible
    └── Easy testing
```

---

# 11. Summary

Coupling measures how strongly software components depend on one another. Modern object-oriented and enterprise applications strive for **low coupling** by programming to interfaces, using dependency injection, and separating responsibilities. Low coupling leads to flexible, maintainable, and testable software.
