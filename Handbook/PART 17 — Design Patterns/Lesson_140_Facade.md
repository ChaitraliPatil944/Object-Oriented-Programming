# Lesson 140 — Facade Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Facade Pattern** is a structural design pattern that provides a **simple, unified interface** to a complex subsystem.

Instead of exposing many classes and interactions, the facade offers one easy entry point.

---

# 2. Problem

A home theater system may require several objects.

```text
DVD Player
Projector
Amplifier
Lights
Screen
```

The client must coordinate them manually.

---

# 3. Solution

Introduce a facade.

```text
Client
   │
HomeTheaterFacade
   │
DVD
Projector
Amplifier
Lights
```

The client calls one method while the facade coordinates everything.

---

# 4. Participants

- Client
- Facade
- Subsystem Classes

---

# 5. Example

### Subsystem

```java
class DVDPlayer {
    void on(){ System.out.println("DVD ON"); }
}

class Projector {
    void on(){ System.out.println("Projector ON"); }
}
```

### Facade

```java
class HomeTheaterFacade {

    private DVDPlayer dvd = new DVDPlayer();
    private Projector projector = new Projector();

    void watchMovie() {
        dvd.on();
        projector.on();
        System.out.println("Movie Started");
    }
}
```

### Client

```java
HomeTheaterFacade theater = new HomeTheaterFacade();
theater.watchMovie();
```

---

# 6. How It Works

```text
Client
   │
Facade
   │
Subsystem A
Subsystem B
Subsystem C
```

The facade delegates work to subsystem components.

---

# 7. Advantages

- Simplifies complex APIs
- Reduces coupling
- Improves readability
- Hides subsystem complexity
- Easier maintenance

---

# 8. Disadvantages

- Facade can become too large if overloaded.
- Does not prevent direct subsystem access.

Because every complicated system eventually acquires one heroic class whose main job is explaining the rest of the system to exhausted developers.

---

# 9. Real-World Uses

- Spring's `JdbcTemplate`
- Home theater controllers
- Payment gateways
- Travel booking systems
- Compiler front ends

---

# 10. Facade vs Adapter

| Facade | Adapter |
|--------|---------|
| Simplifies an interface | Converts an interface |
| Hides complexity | Resolves incompatibility |

---

# 11. Facade vs Proxy

| Facade | Proxy |
|--------|-------|
| Simplifies subsystem access | Controls access to an object |
| Focuses on usability | Focuses on protection, caching, or remote access |

---

# 12. Best Practices

- Keep the facade focused.
- Let subsystem classes retain business logic.
- Use facades to expose common workflows.
- Avoid turning the facade into a "God class."

---

# 13. Interview Questions

1. What problem does the Facade pattern solve?
2. Facade vs Adapter?
3. Facade vs Proxy?
4. When should you introduce a facade?
5. Give real-world examples.

---

# 14. Quick Revision

```text
Facade Pattern

✔ Simplified Interface
✔ Hides Complexity
✔ Reduces Coupling
✔ Coordinates Subsystems

Flow

Client
  │
Facade
  │
Subsystems
```

---

# 15. Summary

The Facade pattern provides a simple interface to a complex subsystem by coordinating multiple underlying components behind a single entry point. It improves usability, reduces coupling, and makes large systems easier to understand, use, and maintain.
